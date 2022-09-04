using CadastroSPA.Cadastro.Domain.Models;
using CadastroSPA.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSPA.Cadastro.Domain.Repository
{
    public interface IEscolaridadeRepository : IRepository<Escolaridade>
    {
        Task<IEnumerable<Escolaridade>> ObterTodos();

        Task<bool> Adicionar(Escolaridade escolaridade);
    }
}
