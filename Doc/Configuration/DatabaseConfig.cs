using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CL03Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Doc.Configuration
{
    public static class DatabaseConfig
    {
        public static void AddDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ClContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("ConexaoPadrao")));
        }

        public static void UseDatabaseConfiguration(this IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();
            using var context = serviceScope.ServiceProvider.GetService<ClContext>();
            context.Database.Migrate();
            context.Database.EnsureCreated();
        }
    }
}