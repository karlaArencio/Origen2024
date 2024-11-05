using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Origen2024.BD.Migrations
{
    /// <inheritdoc />
    public partial class PrimeraRelacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CDocumentoID",
                table: "Personas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Personas_CDocumentoID",
                table: "Personas",
                column: "CDocumentoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_CDocumentos_CDocumentoID",
                table: "Personas",
                column: "CDocumentoID",
                principalTable: "CDocumentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_CDocumentos_CDocumentoID",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_CDocumentoID",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "CDocumentoID",
                table: "Personas");
        }
    }
}
