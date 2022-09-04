using CadastroSPA.Cadastro.Data;
using CadastroSPA.Cadastro.Domain.Models;
using CadastroSPA.Cadastro.Domain.Repository;
using CadastroSPA.Core.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSPA.Cadastro.Data.Repository
{
    public class AlunoRepository : IAlunoRepository
    {

        private readonly CadastroContext _context;

        public AlunoRepository(CadastroContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public void Adicionar(Alunos aluno)
        {
            _context.Alunos.Add(aluno);
        }

        public void Atualizar(Alunos aluno)
        {
            _context.Alunos.Update(aluno);
        }

        public async Task<IEnumerable<Alunos>> ObterTodos()
        {
            return await _context.Alunos.AsNoTracking().ToListAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
