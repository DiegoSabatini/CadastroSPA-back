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
    public class EscolaridadeMapping : IEntityTypeConfiguration<Escolaridade>
    {
        public void Configure(EntityTypeBuilder<Escolaridade> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Descricao)
               .IsRequired()
               .HasColumnType("varchar(250)");

            builder
                .HasOne(p => p.Alunos)
                .WithOne(p => p.Escolaridade)
                .HasForeignKey<Alunos>(p => p.IdEscolaridade);

            builder.ToTable("Escolaridade");


        }
    }
}
