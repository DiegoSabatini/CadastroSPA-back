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
    public class HistoricoEscolarRepository : IHistoricoEscolarRepository
    {
        private readonly CadastroContext _context;

        public HistoricoEscolarRepository(CadastroContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public async Task<bool> Adicionar(HistoricoEscolar historicoEscolar)
        {
            _context.HistoricoEscolar.Add(historicoEscolar);
            return await _context.Commit();
        }

        public async Task<bool> Atualizar(HistoricoEscolar historicoEscolar)
        {
            _context.HistoricoEscolar.Update(historicoEscolar);
            return await _context.Commit();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public async Task<HistoricoEscolar> ObterPorId(Guid id)
        {
            return await _context.HistoricoEscolar.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
