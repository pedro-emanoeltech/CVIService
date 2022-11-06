using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CurriculoVitaeInteligenteInfra.Migrations
{
    public partial class Ajuste1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Segmento",
                newName: "Setor");

            migrationBuilder.AddColumn<Guid>(
                name: "NacionalidadeId",
                table: "Perfil",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SegmentoId",
                table: "Perfil",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SegmentoId1",
                table: "Perfil",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Perfil_SegmentoId",
                table: "Perfil",
                column: "SegmentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Perfil_SegmentoId1",
                table: "Perfil",
                column: "SegmentoId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Perfil_Nacionalidade_SegmentoId",
                table: "Perfil",
                column: "SegmentoId",
                principalTable: "Nacionalidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Perfil_Segmento_SegmentoId1",
                table: "Perfil",
                column: "SegmentoId1",
                principalTable: "Segmento",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Perfil_Nacionalidade_SegmentoId",
                table: "Perfil");

            migrationBuilder.DropForeignKey(
                name: "FK_Perfil_Segmento_SegmentoId1",
                table: "Perfil");

            migrationBuilder.DropIndex(
                name: "IX_Perfil_SegmentoId",
                table: "Perfil");

            migrationBuilder.DropIndex(
                name: "IX_Perfil_SegmentoId1",
                table: "Perfil");

            migrationBuilder.DropColumn(
                name: "NacionalidadeId",
                table: "Perfil");

            migrationBuilder.DropColumn(
                name: "SegmentoId",
                table: "Perfil");

            migrationBuilder.DropColumn(
                name: "SegmentoId1",
                table: "Perfil");

            migrationBuilder.RenameColumn(
                name: "Setor",
                table: "Segmento",
                newName: "Descricao");
        }
    }
}
