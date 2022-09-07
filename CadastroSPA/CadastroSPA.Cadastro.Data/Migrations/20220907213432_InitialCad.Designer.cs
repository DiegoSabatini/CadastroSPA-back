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
    [Migration("20220907213432_InitialCad")]
    partial class InitialCad
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
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2")
                        .HasColumnName("DataNascimento");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Email");

                    b.Property<Guid>("IdEscolaridade")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("IdEscolaridade");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Nome");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Sobrenome");

                    b.HasKey("Id");

                    b.HasIndex("IdEscolaridade");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("CadastroSPA.Cadastro.Domain.Models.Escolaridade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Descricao");

                    b.HasKey("Id");

                    b.ToTable("Escolaridade");
                });

            modelBuilder.Entity("CadastroSPA.Cadastro.Domain.Models.Alunos", b =>
                {
                    b.HasOne("CadastroSPA.Cadastro.Domain.Models.Escolaridade", "Escolaridade")
                        .WithMany()
                        .HasForeignKey("IdEscolaridade")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Escolaridade");
                });
#pragma warning restore 612, 618
        }
    }
}