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


        [ForeignKey("IdEscolaridade")]
        public Escolaridade Escolaridade { get;  private set;}


        /// <summary>
        /// EF constructor
        /// </summary>
        private Alunos() { }

        public Alunos(string nome, string sobreNome, string email, DateTime dataNascimento, Guid idEscolaridade, Guid id = new Guid()) {
            Id = id;
            Nome = nome;
            Sobrenome = sobreNome;
            Email = email;
            DataNascimento = dataNascimento;
            IdEscolaridade = IdEscolaridade;
        }

    }
}
