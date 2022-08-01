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
    public class EscolaridadeService : IEscolaridadeService
    {
        private readonly IEscolaridadeRepository _escolaridadeRepository;

        public EscolaridadeService(IEscolaridadeRepository escolaridadeRepository)
        {
            _escolaridadeRepository = escolaridadeRepository;
        }


        public async Task<IEnumerable<Escolaridade>> ObterTodos()
        {
            return await _escolaridadeRepository.ObterTodos();
        }

        public void Dispose()
        {
            _escolaridadeRepository.Dispose();
        }
    }
}
