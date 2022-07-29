using Microsoft.OpenApi.Models;

namespace CadastroSPA.Identidade.API.Configuration
{
    public static class SwaggerConfig
    {
        public static IServiceCollection AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo()
                {
                    Title = "CadastroSPA Identidade API",
                    Description = "",
                    Contact = new OpenApiContact() { Name = "Diego Sabatini", Email = "diegosabatiniguimaraes@gmail.com" },
                    License = new OpenApiLicense() { Name = "", Url = new Uri("") }
                });

            });

            return services;
        }

        public static IApplicationBuilder UseSwaggerConfiguration(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            });

            return app;
        }
    }
}
