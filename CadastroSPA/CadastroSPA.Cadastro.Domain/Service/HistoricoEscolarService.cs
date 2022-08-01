using CadastroSPA.Cadastro.Domain.Models;
using CadastroSPA.Cadastro.Domain.Repository;
using CadastroSPA.Cadastro.Domain.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSPA.Cadastro.Domain.Service
{
    public class HistoricoEscolarService : IHistoricoEscolaService
    {
        private readonly IHistoricoEscolarRepository _historicoEscolarRepository;

        public HistoricoEscolarService(IHistoricoEscolarRepository historicoEscolarRepository)
        {
            _historicoEscolarRepository = historicoEscolarRepository;
        }

        public void Adicionar(HistoricoEscolar historicoEscolar)
        {
            _historicoEscolarRepository.Adicionar(historicoEscolar);
        }

        public void Atualizar(HistoricoEscolar historicoEscolar)
        {
            _historicoEscolarRepository.Atualizar(historicoEscolar);
        }

       

        public async Task<HistoricoEscolar> ObterPorId(Guid id)
        {
            return await _historicoEscolarRepository.ObterPorId(id);
        }

        public void Dispose()
        {
            _historicoEscolarRepository.Dispose();
        }
    }
}
