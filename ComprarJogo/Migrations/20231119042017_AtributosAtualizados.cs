using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComprarJogo.Migrations
{
    /// <inheritdoc />
    public partial class AtributosAtualizados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Clientes_IdCliente_CpfCliente",
                table: "Compras");

            migrationBuilder.DropIndex(
                name: "IX_Compras_IdCliente_CpfCliente",
                table: "Compras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "CpfCliente",
                table: "Compras");

            migrationBuilder.AlterColumn<string>(
                name: "Genero",
                table: "Jogos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Jogos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AddColumn<int>(
                name: "IdBiblioteca",
                table: "Jogos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<double>(
                name: "Valor",
                table: "Compras",
                type: "float",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdBiblioteca",
                table: "Compras",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdReembolso",
                table: "Compras",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "StatusCompra",
                table: "Compras",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Clientes",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataNascimento",
                table: "Clientes",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "IdCliente");

            migrationBuilder.CreateTable(
                name: "Reemboolsos",
                columns: table => new
                {
                    ReembolsoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Motivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChavePix = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reemboolsos", x => x.ReembolsoId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Compras_IdReembolso",
                table: "Compras",
                column: "IdReembolso",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_CPF",
                table: "Clientes",
                column: "CPF",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Compras_IdCliente",
                table: "Compras",
                column: "IdCliente",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Clientes_IdCompra",
                table: "Compras",
                column: "IdCompra",
                principalTable: "Clientes",
                principalColumn: "IdCliente",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Reemboolsos_IdReembolso",
                table: "Compras",
                column: "IdReembolso",
                principalTable: "Reemboolsos",
                principalColumn: "ReembolsoId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Clientes_IdCompra",
                table: "Compras");

            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Reemboolsos_IdReembolso",
                table: "Compras");

            migrationBuilder.DropTable(
                name: "Reemboolsos");

            migrationBuilder.DropIndex(
                name: "IX_Compras_IdReembolso",
                table: "Compras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_CPF",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "IdBiblioteca",
                table: "Jogos");

            migrationBuilder.DropColumn(
                name: "IdBiblioteca",
                table: "Compras");

            migrationBuilder.DropColumn(
                name: "IdReembolso",
                table: "Compras");

            migrationBuilder.DropColumn(
                name: "StatusCompra",
                table: "Compras");

            migrationBuilder.AlterColumn<string>(
                name: "Genero",
                table: "Jogos",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Jogos",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Valor",
                table: "Compras",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CpfCliente",
                table: "Compras",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Senha",
                table: "Clientes",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Clientes",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Clientes",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataNascimento",
                table: "Clientes",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                columns: new[] { "IdCliente", "CPF" });

            migrationBuilder.CreateIndex(
                name: "IX_Compras_IdCliente_CpfCliente",
                table: "Compras",
                columns: new[] { "IdCliente", "CpfCliente" },
                unique: true,
                filter: "[CpfCliente] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Clientes_IdCliente_CpfCliente",
                table: "Compras",
                columns: new[] { "IdCliente", "CpfCliente" },
                principalTable: "Clientes",
                principalColumns: new[] { "IdCliente", "CPF" });
        }
    }
}
