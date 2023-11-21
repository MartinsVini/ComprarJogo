using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComprarJogo.Migrations
{
    /// <inheritdoc />
    public partial class MultiJogoComp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Compras_IdJogo",
                table: "Compras");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_IdJogo",
                table: "Compras",
                column: "IdJogo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Compras_IdJogo",
                table: "Compras");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_IdJogo",
                table: "Compras",
                column: "IdJogo",
                unique: true);
        }
    }
}
