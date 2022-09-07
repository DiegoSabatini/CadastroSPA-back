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

namespace CadastroSPA.Cadastro.Data
{
    public class CadastroContext : DbContext, IUnitOfWork
    {
        public CadastroContext(DbContextOptions<CadastroContext> options)
            : base(options) { }

        public DbSet<Alunos> Alunos { get; set; }
        public DbSet<Escolaridade> Escolaridade { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(
              e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(100)");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CadastroContext).Assembly);
        }

        public async Task<bool> Commit()
        {
            return await base.SaveChangesAsync() > 0;
        }
    }
}
