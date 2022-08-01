using CadastroSPA.Cadastro.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSPA.Cadastro.Infra.CrossCutting.IoC.Configuration
{
    public static class ContextConfig
    {
        public static IServiceCollection ConfigureContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CadastroContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<CadastroContext>();

            services.AddSingleton<IConfiguration>(configuration);

            return services;
        }
    }
}
