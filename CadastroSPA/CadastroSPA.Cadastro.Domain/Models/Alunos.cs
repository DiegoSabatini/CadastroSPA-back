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
           public string Nome { get;  set; }
           public string Sobrenome { get;  set; }
           public string Email { get;  set; }
           public DateTime DataNascimento { get;  set; }
           public Guid IdEscolaridade { get;  set; }
           public Guid IdHistoricoEscolar { get;  set; }
           public Escolaridade Escolaridade { get;  set;}
           public HistoricoEscolar HistoricoEscolar { get;  set; }

        protected Alunos() { }

    }
}
