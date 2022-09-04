using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadastroSPA.Cadastro.Data.Migrations
{
    public partial class InitialCadastro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Escolaridade",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Escolaridade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HistoricoEscolar",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(150)", nullable: false),
                    Formato = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoEscolar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(250)", nullable: false),
                    Sobrenome = table.Column<string>(type: "varchar(250)", nullable: false),
                    Email = table.Column<string>(type: "varchar(250)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "DATE", nullable: false),
                    IdEscolaridade = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHistoricoEscolar = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alunos_Escolaridade_IdEscolaridade",
                        column: x => x.IdEscolaridade,
                        principalTable: "Escolaridade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Alunos_HistoricoEscolar_IdHistoricoEscolar",
                        column: x => x.IdHistoricoEscolar,
                        principalTable: "HistoricoEscolar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_IdEscolaridade",
                table: "Alunos",
                column: "IdEscolaridade",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_IdHistoricoEscolar",
                table: "Alunos",
                column: "IdHistoricoEscolar",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Escolaridade");

            migrationBuilder.DropTable(
                name: "HistoricoEscolar");
        }
    }
}
