using CadastroSPA.Cadastro.Domain.Service;
using CadastroSPA.Cadastro.Domain.Service.Interface;
using CadastroSPA.Core.Data;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSPA.Cadastro.Infra.CrossCutting.IoC.Configuration
{
    public static class ServicesConfig
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IAlunoService, AlunoService>();
            services.AddScoped<IEscolaridadeService, EscolaridadeService>();
            services.AddScoped<IHistoricoEscolaService, HistoricoEscolarService>();

            return services;
        }
    }
}
