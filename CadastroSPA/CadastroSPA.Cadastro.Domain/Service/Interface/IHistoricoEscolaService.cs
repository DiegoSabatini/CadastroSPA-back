using CadastroSPA.Cadastro.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSPA.Cadastro.Domain.Service.Interface
{
    public interface IHistoricoEscolaService : IDisposable
    {
        Task<HistoricoEscolar> ObterPorId(Guid id);
        void Adicionar(HistoricoEscolar historicoEscolar);
        void Atualizar(HistoricoEscolar historicoEscolar);
    }
}
