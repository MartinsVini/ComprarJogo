using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComprarJogo.Migrations
{
    /// <inheritdoc />
    public partial class FixKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Clientes_ClienteCPF",
                table: "Compras");

            migrationBuilder.DropIndex(
                name: "IX_Compras_ClienteCPF",
                table: "Compras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.AddColumn<int>(
                name: "ClienteIdCliente",
                table: "Compras",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                columns: new[] { "IdCliente", "CPF" });

            migrationBuilder.CreateIndex(
                name: "IX_Compras_ClienteIdCliente_ClienteCPF",
                table: "Compras",
                columns: new[] { "ClienteIdCliente", "ClienteCPF" });

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Clientes_ClienteIdCliente_ClienteCPF",
                table: "Compras",
                columns: new[] { "ClienteIdCliente", "ClienteCPF" },
                principalTable: "Clientes",
                principalColumns: new[] { "IdCliente", "CPF" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Clientes_ClienteIdCliente_ClienteCPF",
                table: "Compras");

            migrationBuilder.DropIndex(
                name: "IX_Compras_ClienteIdCliente_ClienteCPF",
                table: "Compras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "ClienteIdCliente",
                table: "Compras");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "CPF");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_ClienteCPF",
                table: "Compras",
                column: "ClienteCPF");

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Clientes_ClienteCPF",
                table: "Compras",
                column: "ClienteCPF",
                principalTable: "Clientes",
                principalColumn: "CPF");
        }
    }
}
