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
        public string Descricao { get; set; }

        // EF Relation
        public Alunos Alunos { get; set; }


        protected Escolaridade() { }
    }
}
