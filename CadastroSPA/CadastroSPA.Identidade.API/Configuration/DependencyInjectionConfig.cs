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

            services.AddScoped<IAlunoService, AlunoService>();
            services.AddScoped<IEscolaridadeService, EscolaridadeService>();


            services.AddTransient<IAlunoRepository, AlunoRepository>();
            services.AddTransient<IEscolaridadeRepository, EscolaridadeRepository>();

            services.AddScoped<CadastroContext>();

            return services;
        }

    }
}
