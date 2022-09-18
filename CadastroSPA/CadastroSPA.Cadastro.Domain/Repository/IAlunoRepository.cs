using CadastroSPA.Cadastro.Domain.Models;
using CadastroSPA.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSPA.Cadastro.Domain.Repository
{
    public interface IAlunoRepository : IRepository<Alunos>
    {
        Task<IEnumerable<Alunos>> ObterTodos();
        Task<Alunos> ObterPorId(Guid id);
        Task Adicionar(Alunos aluno);
        Task Atualizar(Alunos aluno);


    }
}
