using CadastroSPA.Cadastro.Data;
using CadastroSPA.Cadastro.Data.Repository;
using CadastroSPA.Cadastro.Domain.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSPA.Cadastro.API.Configuration
{
    public static class RepositoryConfig
    {
        public static IServiceCollection ConfigureRepositories(this IServiceCollection services)
        {
            services.AddScoped<CadastroContext>();
            services.AddScoped<IAlunoRepository, AlunoRepository>();
            services.AddScoped<IEscolaridadeRepository, EscolaridadeRepository>();
            services.AddScoped<IHistoricoEscolarRepository, HistoricoEscolarRepository>();
            return services;
           
        }
    }
}
