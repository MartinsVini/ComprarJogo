using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComprarJogo.Migrations
{
    /// <inheritdoc />
    public partial class Pagamento3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Pagamento_IdPagamento",
                table: "Compras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pagamento",
                table: "Pagamento");

            migrationBuilder.RenameTable(
                name: "Pagamento",
                newName: "Pagamentos");

            migrationBuilder.AlterColumn<string>(
                name: "DataCompra",
                table: "Compras",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Valor",
                table: "Compras",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pagamentos",
                table: "Pagamentos",
                column: "IdPagamento");

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Pagamentos_IdPagamento",
                table: "Compras",
                column: "IdPagamento",
                principalTable: "Pagamentos",
                principalColumn: "IdPagamento",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Pagamentos_IdPagamento",
                table: "Compras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pagamentos",
                table: "Pagamentos");

            migrationBuilder.DropColumn(
                name: "Valor",
                table: "Compras");

            migrationBuilder.RenameTable(
                name: "Pagamentos",
                newName: "Pagamento");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCompra",
                table: "Compras",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pagamento",
                table: "Pagamento",
                column: "IdPagamento");

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Pagamento_IdPagamento",
                table: "Compras",
                column: "IdPagamento",
                principalTable: "Pagamento",
                principalColumn: "IdPagamento",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
