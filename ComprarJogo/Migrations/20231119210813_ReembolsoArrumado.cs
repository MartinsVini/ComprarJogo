using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComprarJogo.Migrations
{
    /// <inheritdoc />
    public partial class ReembolsoArrumado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Reemboolsos_IdReembolso",
                table: "Compras");

            migrationBuilder.DropTable(
                name: "Reemboolsos");

            migrationBuilder.AddColumn<string>(
                name: "StatusPagamento",
                table: "Pagamentos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Reembolsos",
                columns: table => new
                {
                    IdReembolso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Motivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChavePix = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reembolsos", x => x.IdReembolso);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Reembolsos_IdReembolso",
                table: "Compras",
                column: "IdReembolso",
                principalTable: "Reembolsos",
                principalColumn: "IdReembolso",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Reembolsos_IdReembolso",
                table: "Compras");

            migrationBuilder.DropTable(
                name: "Reembolsos");

            migrationBuilder.DropColumn(
                name: "StatusPagamento",
                table: "Pagamentos");

            migrationBuilder.CreateTable(
                name: "Reemboolsos",
                columns: table => new
                {
                    ReembolsoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChavePix = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Motivo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reemboolsos", x => x.ReembolsoId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Reemboolsos_IdReembolso",
                table: "Compras",
                column: "IdReembolso",
                principalTable: "Reemboolsos",
                principalColumn: "ReembolsoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
