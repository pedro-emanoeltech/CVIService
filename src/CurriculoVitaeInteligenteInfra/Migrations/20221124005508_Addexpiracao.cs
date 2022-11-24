using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CurriculoVitaeInteligenteInfra.Migrations
{
    /// <inheritdoc />
    public partial class Addexpiracao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataExpiracao",
                table: "TokenAuth",
                type: "timestamp without time zone",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataExpiracao",
                table: "TokenAuth");
        }
    }
}
