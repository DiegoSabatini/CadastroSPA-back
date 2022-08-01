using CadastroSPA.Cadastro.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSPA.Cadastro.Data.Mappings
{
    public class AlunosMapping : IEntityTypeConfiguration<Alunos>
    {
        public void Configure(EntityTypeBuilder<Alunos> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)
               .IsRequired()
               .HasColumnType("varchar(250)");

            builder.Property(c => c.Sobrenome)
             .IsRequired()
             .HasColumnType("varchar(250)");

            builder.Property(c => c.Email)
              .IsRequired()
              .HasColumnType("varchar(250)");

            builder.Property(c => c.DataNascimento)
             .IsRequired()
             .HasColumnType("DATE");

            builder.ToTable("Alunos");
        }
    }
}
