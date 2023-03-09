using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Licenta.Migrations
{
    public partial class tipcombustibil : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipCombustibilID",
                table: "Vehicul",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TipCombustibil",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipulCombustibil = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipCombustibil", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicul_TipCombustibilID",
                table: "Vehicul",
                column: "TipCombustibilID");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicul_TipCombustibil_TipCombustibilID",
                table: "Vehicul",
                column: "TipCombustibilID",
                principalTable: "TipCombustibil",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicul_TipCombustibil_TipCombustibilID",
                table: "Vehicul");

            migrationBuilder.DropTable(
                name: "TipCombustibil");

            migrationBuilder.DropIndex(
                name: "IX_Vehicul_TipCombustibilID",
                table: "Vehicul");

            migrationBuilder.DropColumn(
                name: "TipCombustibilID",
                table: "Vehicul");
        }
    }
}
