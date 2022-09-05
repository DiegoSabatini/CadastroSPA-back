using CadastroSPA.Cadastro.Data;
using CadastroSPA.Cadastro.Data.Repository;
using CadastroSPA.Cadastro.Domain.Repository;
using CadastroSPA.Cadastro.Domain.Service;
using CadastroSPA.Cadastro.Domain.Service.Interface;

namespace CadastroSPA.Identidade.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<CadastroContext>();

            services.AddTransient<IAlunoService, AlunoService>();
            services.AddTransient<IEscolaridadeService, EscolaridadeService>();
            services.AddTransient<IHistoricoEscolaService, HistoricoEscolarService>();


            services.AddTransient<IAlunoRepository, AlunoRepository>();
            services.AddTransient<IEscolaridadeRepository, EscolaridadeRepository>();
            services.AddTransient<IHistoricoEscolarRepository, HistoricoEscolarRepository>();



            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            return services;
        }

    }
}
