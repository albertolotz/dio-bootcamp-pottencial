using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Doc.CL02Manager.Validator;
using FluentValidation.AspNetCore;

namespace Doc.Configuration
{
    public static class FluentValidationConfig
    {
        public static void AddFluentValidationConfiguration(this IServiceCollection services)
        {
            services.AddControllers()
                .AddFluentValidation(fv => 
                    {
                        fv.RegisterValidatorsFromAssemblyContaining<NovoClienteValidator>();
                        fv.RegisterValidatorsFromAssemblyContaining <AlteraClienteValidator>();
                        fv.ValidatorOptions.LanguageManager.Culture = new CultureInfo("pt-BR");
                    });
        }
    }
}