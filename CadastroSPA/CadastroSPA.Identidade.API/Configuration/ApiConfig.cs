using CadastroSPA.Cadastro.Data;
using CadastroSPA.Identidade.API.Configuration;
using Microsoft.EntityFrameworkCore;

namespace CadastroSPA.Identidade.API.Configuration
{
    public static class ApiConfig
    {
        public static IServiceCollection AddApiConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();

            services.AddDbContext<CadastroContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            var origin = configuration.GetValue<string>("AppSettings:Origin").Split(",");
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                                          builder =>
                                          {
                                              builder.WithOrigins(origin)
                                              .AllowAnyHeader()
                                              .AllowAnyMethod();
                                          });

            });


            return services;
        }

        public static IApplicationBuilder UseApiConfiguration(this IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseIdentityConfiguration();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            return app;
        }

    }
}
