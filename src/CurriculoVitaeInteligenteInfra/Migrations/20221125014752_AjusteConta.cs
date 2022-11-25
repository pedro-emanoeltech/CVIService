using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CurriculoVitaeInteligenteInfra.Migrations
{
    /// <inheritdoc />
    public partial class AjusteConta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoPerfil",
                table: "Perfil");

            migrationBuilder.AddColumn<string>(
                name: "TipoConta",
                table: "Conta",
                type: "character varying(20)",
                maxLength: 20,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoConta",
                table: "Conta");

            migrationBuilder.AddColumn<string>(
                name: "TipoPerfil",
                table: "Perfil",
                type: "character varying(5)",
                maxLength: 5,
                nullable: true);
        }
    }
}
