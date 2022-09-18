using CadastroSPA.Cadastro.Data;
using CadastroSPA.Identidade.API.Configuration;
using CadastroSPA.Identidade.API.Extensions;
using Microsoft.EntityFrameworkCore;

namespace CadastroSPA.Identidade.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IHostEnvironment hostEnvironment)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(hostEnvironment.ContentRootPath)
                .AddJsonFile("appsettings.json", true, true)
                .AddJsonFile($"appsettings.{hostEnvironment.EnvironmentName}.json", true, true)
                .AddEnvironmentVariables();



            if (hostEnvironment.IsDevelopment())
            {
                builder.AddUserSecrets<Startup>();
            }

            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApiConfiguration(Configuration);
            services.AddIdentityConfiguration(Configuration);
            services.AddSwaggerConfiguration();
            services.ResolveDependencies();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors();
            app.UseSwaggerConfiguration();

            app.UseMiddleware<ExceptionMiddleware>();

            app.UseApiConfiguration(env);
        }

    }
}
