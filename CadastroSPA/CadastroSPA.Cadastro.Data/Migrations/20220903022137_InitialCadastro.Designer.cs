﻿// <auto-generated />
using System;
using CadastroSPA.Cadastro.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CadastroSPA.Cadastro.Data.Migrations
{
    [DbContext(typeof(CadastroContext))]
    [Migration("20220903022137_InitialCadastro")]
    partial class InitialCadastro
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CadastroSPA.Cadastro.Domain.Models.Alunos", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("DATE");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<Guid>("IdEscolaridade")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdHistoricoEscolar")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.HasKey("Id");

                    b.HasIndex("IdEscolaridade")
                        .IsUnique();

                    b.HasIndex("IdHistoricoEscolar")
                        .IsUnique();

                    b.ToTable("Alunos", (string)null);
                });

            modelBuilder.Entity("CadastroSPA.Cadastro.Domain.Models.Escolaridade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Escolaridade", (string)null);
                });

            modelBuilder.Entity("CadastroSPA.Cadastro.Domain.Models.HistoricoEscolar", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Formato")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("Id");

                    b.ToTable("HistoricoEscolar", (string)null);
                });

            modelBuilder.Entity("CadastroSPA.Cadastro.Domain.Models.Alunos", b =>
                {
                    b.HasOne("CadastroSPA.Cadastro.Domain.Models.Escolaridade", "Escolaridade")
                        .WithOne("Alunos")
                        .HasForeignKey("CadastroSPA.Cadastro.Domain.Models.Alunos", "IdEscolaridade")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CadastroSPA.Cadastro.Domain.Models.HistoricoEscolar", "HistoricoEscolar")
                        .WithOne("Alunos")
                        .HasForeignKey("CadastroSPA.Cadastro.Domain.Models.Alunos", "IdHistoricoEscolar")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Escolaridade");

                    b.Navigation("HistoricoEscolar");
                });

            modelBuilder.Entity("CadastroSPA.Cadastro.Domain.Models.Escolaridade", b =>
                {
                    b.Navigation("Alunos");
                });

            modelBuilder.Entity("CadastroSPA.Cadastro.Domain.Models.HistoricoEscolar", b =>
                {
                    b.Navigation("Alunos");
                });
#pragma warning restore 612, 618
        }
    }
}