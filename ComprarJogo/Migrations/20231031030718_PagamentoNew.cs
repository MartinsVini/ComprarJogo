using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComprarJogo.Migrations
{
    /// <inheritdoc />
    public partial class PagamentoNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCompra",
                table: "Compras",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "IdPagamento",
                table: "Compras",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Pagamento",
                columns: table => new
                {
                    IdPagamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalPagamento = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagamento", x => x.IdPagamento);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Compras_IdPagamento",
                table: "Compras",
                column: "IdPagamento",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Pagamento_IdPagamento",
                table: "Compras",
                column: "IdPagamento",
                principalTable: "Pagamento",
                principalColumn: "IdPagamento",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Pagamento_IdPagamento",
                table: "Compras");

            migrationBuilder.DropTable(
                name: "Pagamento");

            migrationBuilder.DropIndex(
                name: "IX_Compras_IdPagamento",
                table: "Compras");

            migrationBuilder.DropColumn(
                name: "IdPagamento",
                table: "Compras");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCompra",
                table: "Compras",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }
    }
}
