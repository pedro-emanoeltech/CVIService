using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CurriculoVitaeInteligenteInfra.Migrations
{
    /// <inheritdoc />
    public partial class AlterarToken : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpiryTimeStamp",
                table: "TokenAuth");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataExpiracao",
                table: "TokenAuth",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DataExpiracao",
                table: "TokenAuth",
                type: "text",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpiryTimeStamp",
                table: "TokenAuth",
                type: "timestamp without time zone",
                nullable: true);
        }
    }
}
