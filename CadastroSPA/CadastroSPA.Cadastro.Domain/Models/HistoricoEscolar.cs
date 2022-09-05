using CadastroSPA.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSPA.Cadastro.Domain.Models
{
    [Table("HistoricoEscolar")]
    public class HistoricoEscolar : Entity
    {
        [Column("Nome")]
        public string Nome { get; private set; }

        [Column("Formato")]
        public string Formato { get;  private set; }
       

        public HistoricoEscolar(string nome, string formato) {
            Nome = nome;
            Formato = formato;
        }

    }
}
