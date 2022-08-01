using CadastroSPA.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSPA.Cadastro.Domain.Models
{
    public class Escolaridade : Entity
    {
        public string Descricao { get; private set; }

        // EF Relation
        public ICollection<Alunos> Alunos { get; set; }

        protected Escolaridade() { }

        public Escolaridade(string descricao)
        {
            Descricao = descricao;
        }

    }
}
