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
    public class HistoricoEscolarAppService : IHistoricoEscolarAppService
    {
        private readonly IHistoricoEscolarRepository _historicoEscolarRepository;
        private readonly IMapper _mapper;

        public HistoricoEscolarAppService(IHistoricoEscolarRepository historicoEscolarRepository,  IMapper mapper)
        {
            this._historicoEscolarRepository = historicoEscolarRepository;
            this._mapper = mapper;
        }

        public async Task<bool> Adicionar(HistoricoEscolarViewModel historico)
        {
            return await _historicoEscolarRepository.Adicionar(_mapper.Map<HistoricoEscolar>(historico));
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
