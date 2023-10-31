using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComprarJogo.Migrations
{
    /// <inheritdoc />
    public partial class @try : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Clientes_IdCliente_CpfCliente",
                table: "Compras");

            migrationBuilder.AlterColumn<string>(
                name: "CpfCliente",
                table: "Compras",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Clientes_IdCliente_CpfCliente",
                table: "Compras",
                columns: new[] { "IdCliente", "CpfCliente" },
                principalTable: "Clientes",
                principalColumns: new[] { "IdCliente", "CPF" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Clientes_IdCliente_CpfCliente",
                table: "Compras");

            migrationBuilder.AlterColumn<string>(
                name: "CpfCliente",
                table: "Compras",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Clientes_IdCliente_CpfCliente",
                table: "Compras",
                columns: new[] { "IdCliente", "CpfCliente" },
                principalTable: "Clientes",
                principalColumns: new[] { "IdCliente", "CPF" },
                onDelete: ReferentialAction.Cascade);
        }
    }
}
