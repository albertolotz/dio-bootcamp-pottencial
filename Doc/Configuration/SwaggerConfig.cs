using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.OpenApi.Models;

namespace Doc.Configuration
{
    public static class SwaggerConfig
    {
        public static void AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(c=>
            {
                c.SwaggerDoc("v1", new OpenApiInfo 
                { 
                    Title = "DOC API", 
                    Version = "v1",
                    Description = "API para estudo",
                    Contact = new OpenApiContact
                    {
                        Name = "Alberto Lotz",
                        Email = "alberto10lotz@gmail.com",
                        Url = new Uri("https://github.com/albertolotz")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "OSD",
                        Url = new Uri("https://github.com/albertolotz")
                    },
                    TermsOfService = new Uri("https://github.com/albertolotz")
                });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
        }

        public static void UseSwaggerConfiguration(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI();   
        }
    }
}
