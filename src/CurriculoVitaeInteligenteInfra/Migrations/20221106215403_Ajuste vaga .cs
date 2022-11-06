using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CurriculoVitaeInteligenteInfra.Migrations
{
    public partial class Ajustevaga : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contatos_Vaga_VagaId",
                table: "Contatos");

            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Vaga_VagaId",
                table: "Endereco");

            migrationBuilder.DropIndex(
                name: "IX_Endereco_VagaId",
                table: "Endereco");

            migrationBuilder.DropIndex(
                name: "IX_Contatos_VagaId",
                table: "Contatos");

            migrationBuilder.DropColumn(
                name: "VagaId",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "VagaId",
                table: "Contatos");

            migrationBuilder.AddColumn<Guid>(
                name: "CidadeId",
                table: "Vaga",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ContatoId",
                table: "Vaga",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "EstadoId",
                table: "Vaga",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vaga_CidadeId",
                table: "Vaga",
                column: "CidadeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vaga_ContatoId",
                table: "Vaga",
                column: "ContatoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vaga_EstadoId",
                table: "Vaga",
                column: "EstadoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Vaga_Cidade_EstadoId",
                table: "Vaga",
                column: "EstadoId",
                principalTable: "Cidade",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vaga_Contatos_ContatoId",
                table: "Vaga",
                column: "ContatoId",
                principalTable: "Contatos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vaga_Estado_CidadeId",
                table: "Vaga",
                column: "CidadeId",
                principalTable: "Estado",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vaga_Cidade_EstadoId",
                table: "Vaga");

            migrationBuilder.DropForeignKey(
                name: "FK_Vaga_Contatos_ContatoId",
                table: "Vaga");

            migrationBuilder.DropForeignKey(
                name: "FK_Vaga_Estado_CidadeId",
                table: "Vaga");

            migrationBuilder.DropIndex(
                name: "IX_Vaga_CidadeId",
                table: "Vaga");

            migrationBuilder.DropIndex(
                name: "IX_Vaga_ContatoId",
                table: "Vaga");

            migrationBuilder.DropIndex(
                name: "IX_Vaga_EstadoId",
                table: "Vaga");

            migrationBuilder.DropColumn(
                name: "CidadeId",
                table: "Vaga");

            migrationBuilder.DropColumn(
                name: "ContatoId",
                table: "Vaga");

            migrationBuilder.DropColumn(
                name: "EstadoId",
                table: "Vaga");

            migrationBuilder.AddColumn<Guid>(
                name: "VagaId",
                table: "Endereco",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "VagaId",
                table: "Contatos",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_VagaId",
                table: "Endereco",
                column: "VagaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contatos_VagaId",
                table: "Contatos",
                column: "VagaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Contatos_Vaga_VagaId",
                table: "Contatos",
                column: "VagaId",
                principalTable: "Vaga",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Vaga_VagaId",
                table: "Endereco",
                column: "VagaId",
                principalTable: "Vaga",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
