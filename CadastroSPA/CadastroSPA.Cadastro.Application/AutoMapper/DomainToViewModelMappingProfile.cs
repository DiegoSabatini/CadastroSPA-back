using AutoMapper;
using CadastroSPA.Cadastro.Application.ViewModels;
using CadastroSPA.Cadastro.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSPA.Cadastro.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Alunos, AlunoViewModel>();
            CreateMap<Escolaridade, EscolaridadeViewModel>();
            CreateMap<HistoricoEscolar, HistoricoEscolarViewModel>();
        }
    }
}
