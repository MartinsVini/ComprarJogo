using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComprarJogo.Migrations
{
    /// <inheritdoc />
    public partial class fuckit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Compras_IdCliente_CpfCliente",
                table: "Compras");

            migrationBuilder.DropIndex(
                name: "IX_Compras_IdJogo",
                table: "Compras");

            migrationBuilder.AlterColumn<string>(
                name: "DataLançamento",
                table: "Jogos",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldMaxLength: 250);

            migrationBuilder.CreateIndex(
                name: "IX_Compras_IdCliente_CpfCliente",
                table: "Compras",
                columns: new[] { "IdCliente", "CpfCliente" },
                unique: true,
                filter: "[CpfCliente] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_IdJogo",
                table: "Compras",
                column: "IdJogo",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Compras_IdCliente_CpfCliente",
                table: "Compras");

            migrationBuilder.DropIndex(
                name: "IX_Compras_IdJogo",
                table: "Compras");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataLançamento",
                table: "Jogos",
                type: "datetime2",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.CreateIndex(
                name: "IX_Compras_IdCliente_CpfCliente",
                table: "Compras",
                columns: new[] { "IdCliente", "CpfCliente" });

            migrationBuilder.CreateIndex(
                name: "IX_Compras_IdJogo",
                table: "Compras",
                column: "IdJogo");
        }
    }
}
