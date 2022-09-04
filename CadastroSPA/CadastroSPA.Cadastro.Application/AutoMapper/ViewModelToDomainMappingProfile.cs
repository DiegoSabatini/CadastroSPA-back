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
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<AlunoViewModel, Alunos>();
            CreateMap<EscolaridadeViewModel, Escolaridade>();
            CreateMap<HistoricoEscolarViewModel, HistoricoEscolar>();
        }
    }
}
