using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CL03Data.Context;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace CL01WebApi
{
    public class AppDbContextFactory :  IDesignTimeDbContextFactory<ClContext>
    {
        public ClContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // Criando o DbContextOptionsBuilder manualmente
            var builder = new DbContextOptionsBuilder<ClContext>();
            // cria a connection string. 
            // requer a connectionstring no appsettings.json
            var connectionString = configuration.GetConnectionString("ConexaoPadrao");
            builder.UseSqlServer(connectionString);

            // Cria o contexto
            return new ClContext(builder.Options);
        }
    }
}