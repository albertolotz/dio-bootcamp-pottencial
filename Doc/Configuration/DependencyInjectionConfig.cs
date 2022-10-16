using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Doc.CL02Manager.Interfaces;
using Doc.CL02Manager.Interfaces.Implementation;
using Doc.CL03Data.Repository;

namespace Doc.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IClienteManager, ClienteManager>();
        }
    }
}