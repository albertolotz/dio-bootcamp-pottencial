//using CL03Data.Context;
//using Doc.CL02Manager.Interfaces;
//using Doc.CL02Manager.Interfaces.Implementation;
//using Doc.CL03Data.Repository;
//using Microsoft.EntityFrameworkCore;
//using FluentValidation.AspNetCore;
//using Doc.CL02Manager.Validator;
//using System.Globalization;
//using Doc.CL02Manager.Mapping;
using Doc.Configuration;

var builder = WebApplication.CreateBuilder(args);

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
if (app.Environment.IsDevelopment())
{
    app.UseSwaggerConfiguration(); // esta é uma chamada personalizada
}
app.UseDatabaseConfiguration();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
