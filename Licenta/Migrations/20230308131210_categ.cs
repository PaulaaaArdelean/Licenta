using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Licenta.Migrations
{
    public partial class categ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategorieVehiculID",
                table: "Vehicul",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CategorieVehicul",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoriaVehicul = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategorieVehicul", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicul_CategorieVehiculID",
                table: "Vehicul",
                column: "CategorieVehiculID");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicul_CategorieVehicul_CategorieVehiculID",
                table: "Vehicul",
                column: "CategorieVehiculID",
                principalTable: "CategorieVehicul",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicul_CategorieVehicul_CategorieVehiculID",
                table: "Vehicul");

            migrationBuilder.DropTable(
                name: "CategorieVehicul");

            migrationBuilder.DropIndex(
                name: "IX_Vehicul_CategorieVehiculID",
                table: "Vehicul");

            migrationBuilder.DropColumn(
                name: "CategorieVehiculID",
                table: "Vehicul");
        }
    }
}
