using CadastroSPA.Cadastro.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSPA.Cadastro.Domain.Service.Interface
{
    public interface IEscolaridadeService : IDisposable
    {
        Task<IEnumerable<Escolaridade>> ObterTodos();

        Task Adicionar(Escolaridade escolaridade);
    }
}
