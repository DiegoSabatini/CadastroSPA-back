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
    public class EscolaridadeRepository : IEscolaridadeRepository
    {
        private readonly CadastroContext _context;

        public EscolaridadeRepository(CadastroContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;


        public async Task<IEnumerable<Escolaridade>> ObterTodos()
        {
            return await _context.Escolaridade.AsNoTracking().ToListAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public async Task<bool> Adicionar(Escolaridade escolaridade)
        {
            _context.Escolaridade.Add(escolaridade);
            return await _context.Commit();
        }
    }
}
