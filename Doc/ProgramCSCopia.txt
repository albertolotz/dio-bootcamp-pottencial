using CL03Data.Context;
using Doc.CL02Manager.Interfaces;
using Doc.CL02Manager.Interfaces.Implementation;
using Doc.CL03Data.Repository;
using Microsoft.EntityFrameworkCore;
using FluentValidation.AspNetCore;
using Doc.CL02Manager.Validator;
using System.Globalization;
using Doc.CL02Manager.Mapping;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ClContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao")));

builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<IClienteManager, ClienteManager>();

builder.Services.AddControllers()
    .AddFluentValidation(fv => 
        {
            fv.RegisterValidatorsFromAssemblyContaining<NovoClienteValidator>();
            fv.RegisterValidatorsFromAssemblyContaining <AlteraClienteValidator>();
            fv.ValidatorOptions.LanguageManager.Culture = new CultureInfo("pt-BR");
        });


builder.Services.AddAutoMapper(
    typeof(NovoClienteMappingProfile), 
    typeof(AlteraClienteMappingProfile)
    ); // adicinar outros, colocar , e add

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
