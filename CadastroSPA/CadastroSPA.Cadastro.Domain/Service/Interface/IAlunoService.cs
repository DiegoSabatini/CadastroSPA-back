using CadastroSPA.Cadastro.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSPA.Cadastro.Domain.Service.Interface
{
    public interface IAlunoService : IDisposable
    {
        Task<IEnumerable<Alunos>> ObterTodos();
        Task<Alunos> ObterPorId(Guid id);
        void Adicionar(Alunos aluno);
        void Atualizar(Alunos aluno);
    }
}
