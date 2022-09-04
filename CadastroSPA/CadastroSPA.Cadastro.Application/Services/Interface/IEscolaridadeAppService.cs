using CadastroSPA.Cadastro.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSPA.Cadastro.Application.Services.Interface
{
    public interface IEscolaridadeAppService : IDisposable
    {
        Task<IEnumerable<EscolaridadeViewModel>> ObterTodos();
        Task<bool> Adicionar(EscolaridadeViewModel produto);
    }
}
