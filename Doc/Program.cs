//using CL03Data.Context;
//using Doc.CL02Manager.Interfaces;
//using Doc.CL02Manager.Interfaces.Implementation;
//using Doc.CL03Data.Repository;
//using Microsoft.EntityFrameworkCore;
//using FluentValidation.AspNetCore;
//using Doc.CL02Manager.Validator;
//using System.Globalization;
//using Doc.CL02Manager.Mapping;
//using System;
using Doc.Configuration;
using Serilog;


IConfigurationRoot configurationLog = GetConfigurationLog();

ConfiguraLog(configurationLog);

try
{
    Log.Information("Iniciando WEB API........");

    var builder = WebApplication.CreateBuilder(args);

    //log 
    builder.Host.UseSerilog();

    // Add services to the container.

    builder.Services.AddDatabaseConfiguration(builder.Configuration);

    builder.Services.AddDependencyInjectionConfiguration();

    builder.Services.AddControllers();

    builder.Services.AddFluentValidationConfiguration();

    builder.Services.AddAutoMapperConfiguration();

    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();

    builder.Services.AddSwaggerConfiguration(); // esta é uma chamada pergonalizada.

    var app = builder.Build();
    
    // Configure the HTTP request pipeline.
    app.UseExceptionHandler("/error");

    if (app.Environment.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
    }

    app.UseDatabaseConfiguration();

     app.UseSwaggerConfiguration(); // esta é uma chamada personalizada

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();

}
catch (Exception ex)
{
    Log.Fatal(ex, "Erro geral");
    throw;
}
finally
{
    Log.CloseAndFlush();
}

//metodos pessoais

static IConfigurationRoot GetConfigurationLog()
{
    string ambiente = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

    var configurationLog = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .AddJsonFile($"appsettings.{ambiente}.json", optional: true)
        .Build();
    return configurationLog;
}

static void ConfiguraLog(IConfigurationRoot configurationLog)
{
    Log.Logger = new LoggerConfiguration()
        .ReadFrom.Configuration(configurationLog)
        .CreateLogger();
}