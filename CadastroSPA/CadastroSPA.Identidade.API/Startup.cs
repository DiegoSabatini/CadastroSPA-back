using CadastroSPA.Cadastro.Data;
using CadastroSPA.Identidade.API.Configuration;
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
            services.AddControllers();

            services.AddDbContext<CadastroContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });


            services.AddIdentityConfiguration(Configuration);

            var origin = Configuration.GetValue<string>("AppSettings:Origin").Split(",");
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

            services.AddApiConfiguration();
            
            services.AddSwaggerConfiguration();
            services.ResolveDependencies();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors();
            app.UseSwaggerConfiguration();

            app.UseApiConfiguration(env);
        }

    }
}
