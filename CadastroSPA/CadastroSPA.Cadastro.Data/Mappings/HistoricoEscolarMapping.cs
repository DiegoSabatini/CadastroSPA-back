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
    public class HistoricoEscolarMapping : IEntityTypeConfiguration<HistoricoEscolar>
    {
        public void Configure(EntityTypeBuilder<HistoricoEscolar> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome)
              .IsRequired()
              .HasColumnType("varchar(150)");

            builder.Property(c => c.Formato)
              .IsRequired()
              .HasColumnType("varchar(100)");


            builder.Property(c => c.Arquivo)
              .IsRequired()
              .HasColumnType("BLOB");

            // 1 : N => HistoricoEscolar : Alunos
            builder.HasMany(c => c.Alunos)
                .WithOne(p => p.HistoricoEscolar)
                .HasForeignKey(p => p.IdHistoricoEscolar);

            builder.ToTable("HistoricoEscolar");
        }
    }
}
