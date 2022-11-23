using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CurriculoVitaeInteligenteInfra.Migrations
{
    /// <inheritdoc />
    public partial class AddToken : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TokenAuth",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Token = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Role = table.Column<string>(type: "text", nullable: true),
                    DataExpiracao = table.Column<string>(type: "text", nullable: true),
                    ExpiryTimeStamp = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DateCreate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ContaId = table.Column<Guid>(type: "uuid", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TokenAuth", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TokenAuth_DateCreate",
                table: "TokenAuth",
                column: "DateCreate");

            migrationBuilder.CreateIndex(
                name: "IX_TokenAuth_Id",
                table: "TokenAuth",
                column: "Id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TokenAuth");
        }
    }
}
