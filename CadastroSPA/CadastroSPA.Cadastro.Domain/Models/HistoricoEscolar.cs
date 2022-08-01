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
        public string Nome { get; private set; }
        public string Formato { get; private set; }
        public byte[] Arquivo { get; private set; }

        public ICollection<Alunos> Alunos { get; set; }

        protected HistoricoEscolar() { }


        public HistoricoEscolar(string nome, string formato, byte[] arquivo)
        {
            Nome = nome;
            Formato = formato;
            Arquivo = arquivo;
        }
    }
}
