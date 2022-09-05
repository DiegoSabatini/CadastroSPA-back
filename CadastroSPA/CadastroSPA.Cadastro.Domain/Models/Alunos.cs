using CadastroSPA.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSPA.Cadastro.Domain.Models
{
    [Table("Alunos")]
    public class Alunos : Entity
    {
           [Column("Nome")]
           public string Nome { get;  set; }

           [Column("Sobrenome")]
           public string Sobrenome { get;  set; }

           [Column("Email")]
           public string Email { get;  set; }

            [Column("DataNascimento")]
            public DateTime DataNascimento { get;  set; }

        [Column("IdEscolaridade")]
        public Guid IdEscolaridade { get;  set; }

        [Column("IdHistoricoEscolar")]
        public Guid IdHistoricoEscolar { get; set; }

        [ForeignKey("IdEscolaridade")]
        public Escolaridade Escolaridade { get;  private set;}

        [ForeignKey("IdHistoricoEscolar")]
        public HistoricoEscolar HistoricoEscolar { get;  set; }

        public Alunos(string nome, string sobreNome, string email, DateTime dataNascimento, Guid idEscolaridade) {
            Nome = nome;
            Sobrenome = sobreNome;
            Email = email;
            DataNascimento = dataNascimento;
            IdEscolaridade = IdEscolaridade;
        }

    }
}
