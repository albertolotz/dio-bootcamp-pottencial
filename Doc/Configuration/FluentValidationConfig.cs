using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Doc.CL02Manager.Validator;
using FluentValidation.AspNetCore;
using Newtonsoft.Json;

namespace Doc.Configuration
{
    public static class FluentValidationConfig
    {
        public static void AddFluentValidationConfiguration(this IServiceCollection services)
        {
            services.AddControllers()
            .AddNewtonsoftJson(x=> x.SerializerSettings.ReferenceLoopHandling=ReferenceLoopHandling.Ignore)
                .AddFluentValidation(fv => 
                    {
                        fv.RegisterValidatorsFromAssemblyContaining<NovoClienteValidator>();
                        fv.RegisterValidatorsFromAssemblyContaining <AlteraClienteValidator>();
                        fv.RegisterValidatorsFromAssemblyContaining <NovoEnderecoValidator>();
                        fv.ValidatorOptions.LanguageManager.Culture = new CultureInfo("pt-BR");
                    });
        }
    }
}