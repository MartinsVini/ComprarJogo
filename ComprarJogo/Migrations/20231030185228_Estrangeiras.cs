using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComprarJogo.Migrations
{
    /// <inheritdoc />
    public partial class Estrangeiras : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Clientes_ClienteIdCliente_ClienteCPF",
                table: "Compras");

            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Jogos_JogoIdJogo",
                table: "Compras");

            migrationBuilder.DropIndex(
                name: "IX_Compras_ClienteIdCliente_ClienteCPF",
                table: "Compras");

            migrationBuilder.DropIndex(
                name: "IX_Compras_JogoIdJogo",
                table: "Compras");

            migrationBuilder.DropColumn(
                name: "ClienteCPF",
                table: "Compras");

            migrationBuilder.DropColumn(
                name: "ClienteIdCliente",
                table: "Compras");

            migrationBuilder.DropColumn(
                name: "JogoIdJogo",
                table: "Compras");

            migrationBuilder.AddColumn<string>(
                name: "CpfCliente",
                table: "Compras",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "IdCliente",
                table: "Compras",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdJogo",
                table: "Compras",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Compras_IdCliente_CpfCliente",
                table: "Compras",
                columns: new[] { "IdCliente", "CpfCliente" });

            migrationBuilder.CreateIndex(
                name: "IX_Compras_IdJogo",
                table: "Compras",
                column: "IdJogo");

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Clientes_IdCliente_CpfCliente",
                table: "Compras",
                columns: new[] { "IdCliente", "CpfCliente" },
                principalTable: "Clientes",
                principalColumns: new[] { "IdCliente", "CPF" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Jogos_IdJogo",
                table: "Compras",
                column: "IdJogo",
                principalTable: "Jogos",
                principalColumn: "IdJogo",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Clientes_IdCliente_CpfCliente",
                table: "Compras");

            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Jogos_IdJogo",
                table: "Compras");

            migrationBuilder.DropIndex(
                name: "IX_Compras_IdCliente_CpfCliente",
                table: "Compras");

            migrationBuilder.DropIndex(
                name: "IX_Compras_IdJogo",
                table: "Compras");

            migrationBuilder.DropColumn(
                name: "CpfCliente",
                table: "Compras");

            migrationBuilder.DropColumn(
                name: "IdCliente",
                table: "Compras");

            migrationBuilder.DropColumn(
                name: "IdJogo",
                table: "Compras");

            migrationBuilder.AddColumn<string>(
                name: "ClienteCPF",
                table: "Compras",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClienteIdCliente",
                table: "Compras",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JogoIdJogo",
                table: "Compras",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Compras_ClienteIdCliente_ClienteCPF",
                table: "Compras",
                columns: new[] { "ClienteIdCliente", "ClienteCPF" });

            migrationBuilder.CreateIndex(
                name: "IX_Compras_JogoIdJogo",
                table: "Compras",
                column: "JogoIdJogo");

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Clientes_ClienteIdCliente_ClienteCPF",
                table: "Compras",
                columns: new[] { "ClienteIdCliente", "ClienteCPF" },
                principalTable: "Clientes",
                principalColumns: new[] { "IdCliente", "CPF" });

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Jogos_JogoIdJogo",
                table: "Compras",
                column: "JogoIdJogo",
                principalTable: "Jogos",
                principalColumn: "IdJogo");
        }
    }
}
