using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComprarJogo.Migrations
{
    /// <inheritdoc />
    public partial class OneToManyFixed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Reembolsos_IdReembolso",
                table: "Compras");

            migrationBuilder.AlterColumn<double>(
                name: "Valor",
                table: "Compras",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Reembolsos_IdReembolso",
                table: "Compras",
                column: "IdReembolso",
                principalTable: "Reembolsos",
                principalColumn: "IdReembolso");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Reembolsos_IdReembolso",
                table: "Compras");

            migrationBuilder.AlterColumn<double>(
                name: "Valor",
                table: "Compras",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Reembolsos_IdReembolso",
                table: "Compras",
                column: "IdReembolso",
                principalTable: "Reembolsos",
                principalColumn: "IdReembolso",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
