using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComprarJogo.Migrations
{
    /// <inheritdoc />
    public partial class OneToManyFixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Clientes_IdCompra",
                table: "Compras");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_IdCliente",
                table: "Compras",
                column: "IdCliente");

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Clientes_IdCliente",
                table: "Compras",
                column: "IdCliente",
                principalTable: "Clientes",
                principalColumn: "IdCliente",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Clientes_IdCliente",
                table: "Compras");

            migrationBuilder.DropIndex(
                name: "IX_Compras_IdCliente",
                table: "Compras");

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Clientes_IdCompra",
                table: "Compras",
                column: "IdCompra",
                principalTable: "Clientes",
                principalColumn: "IdCliente",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
