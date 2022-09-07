using CadastroSPA.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSPA.Cadastro.Domain.Models
{
    [Table("Escolaridade")]
    public class Escolaridade : Entity
    {
        [Column("Descricao")]
        public string Descricao { get; private set; }

      

        /// <summary>
        /// EF constructor
        /// </summary>
        /// 
        private Escolaridade(){  }


        public Escolaridade(string descricao)
        {
            Descricao = descricao;
        }
    }
}
