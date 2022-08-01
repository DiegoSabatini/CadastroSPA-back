using System;
using System.Linq;
using CadastroSPA.Core.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroSPA.Cadastro.Domain.Models;
using CadastroSPA.Cadastro.Data.Mappings;

namespace CadastroSPA.Cadastro.Data.Context
{
    public class CadastroContext : DbContext, IUnitOfWork
    {
        public CadastroContext(DbContextOptions<CadastroContext> options)
            : base(options) { }

        public DbSet<Alunos> Alunos { get; set; }
        public DbSet<HistoricoEscolar> HistoricoEscolar { get; set; }
        public DbSet<Escolaridade> Escolaridade { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunosMapping());

            modelBuilder.ApplyConfiguration(new EscolaridadeMapping());

            modelBuilder.ApplyConfiguration(new HistoricoEscolarMapping());

        }

        public async Task<bool> Commit()
        {
            return await base.SaveChangesAsync() > 0;
        }
    }
}
