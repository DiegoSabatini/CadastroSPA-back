using CadastroSPA.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSPA.Cadastro.Domain.Models
{
    public class Alunos : Entity
    {
            public string Nome { get; private set; }
            public string Sobrenome { get; private set; }
           public string Email { get; private set; }
           public DateTime DataNascimento { get; private set; }
           public Guid IdEscolaridade { get; private set; }
           public Guid IdHistoricoEscolar { get; private set; }
           public Escolaridade Escolaridade { get; private set;}
           public HistoricoEscolar HistoricoEscolar { get; private set; }


        protected Alunos() { }

        public Alunos(string nome, string sobrenome, string email, DateTime dataNascimento, Guid idEscolaridade, Guid idHistorico, Escolaridade escolaridade, HistoricoEscolar historicoEscolar)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            DataNascimento = dataNascimento;
            IdEscolaridade = IdEscolaridade;
            IdHistorico = idHistorico;
            Escolaridade = escolaridade;
            HistoricoEscolar = historicoEscolar;
        }

    }
}
