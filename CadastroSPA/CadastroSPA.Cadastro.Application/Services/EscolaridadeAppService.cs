using AutoMapper;
using CadastroSPA.Cadastro.Application.Services.Interface;
using CadastroSPA.Cadastro.Application.ViewModels;
using CadastroSPA.Cadastro.Domain.Models;
using CadastroSPA.Cadastro.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSPA.Cadastro.Application.Services
{
    public class EscolaridadeAppService : IEscolaridadeAppService
    {
        private readonly IEscolaridadeRepository _escolaridadeRepository;
        private readonly IMapper _mapper;

        public EscolaridadeAppService(IEscolaridadeRepository escolaridadeRepository, IMapper mapper)
        {
            _escolaridadeRepository = escolaridadeRepository;
            _mapper = mapper;
        }


        public async Task<bool> Adicionar(EscolaridadeViewModel escolaridadeViewModel)
        {
            return await _escolaridadeRepository.Adicionar(_mapper.Map<Escolaridade>(escolaridadeViewModel));
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<EscolaridadeViewModel>> ObterTodos()
        {
            return _mapper.Map<IEnumerable<EscolaridadeViewModel>>(await _escolaridadeRepository.ObterTodos());
        }
    }
}
