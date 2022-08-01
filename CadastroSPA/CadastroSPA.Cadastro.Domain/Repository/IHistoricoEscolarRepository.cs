using CadastroSPA.Cadastro.Domain.Models;
using CadastroSPA.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSPA.Cadastro.Domain.Repository
{
    public interface IHistoricoEscolarRepository : IRepository<HistoricoEscolar>
    {
        Task<HistoricoEscolar> ObterPorId(Guid id);
        void Adicionar(HistoricoEscolar historicoEscolar);
        void Atualizar(HistoricoEscolar historicoEscolar);

    }
}
