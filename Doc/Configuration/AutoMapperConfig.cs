using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Doc.CL02Manager.Mapping;

namespace Doc.Configuration
{
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            services.AddAutoMapper
            (
                typeof(NovoClienteMappingProfile), 
                typeof(AlteraClienteMappingProfile)
            ); 
        }
    }
}