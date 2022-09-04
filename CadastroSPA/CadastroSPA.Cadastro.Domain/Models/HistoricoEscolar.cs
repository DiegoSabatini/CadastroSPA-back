using CadastroSPA.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSPA.Cadastro.Domain.Models
{
    public class HistoricoEscolar : Entity
    {
        public string Nome { get;  set; }
        public string Formato { get;  set; }
        public Alunos Alunos { get; set; }

        protected HistoricoEscolar() { }

    }
}
