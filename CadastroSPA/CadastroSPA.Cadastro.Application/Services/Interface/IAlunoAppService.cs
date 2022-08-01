using CadastroSPA.Cadastro.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSPA.Cadastro.Application.Services.Interface
{
    public interface IAlunoAppService : IDisposable
    {
        Task<IEnumerable<AlunoViewModel>> ObterTodos();
        void Adicionar(AlunoViewModel produto);
        void Atualizar(AlunoViewModel produto);
    }
}
