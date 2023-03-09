using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Licenta.Migrations
{
    public partial class oferte : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CodPostal",
                table: "Client",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Oferta",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataInceputValabilitate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataSfarsitValabilitate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehiculID = table.Column<int>(type: "int", nullable: true),
                    ClientID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oferta", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Oferta_Client_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Client",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Oferta_Vehicul_VehiculID",
                        column: x => x.VehiculID,
                        principalTable: "Vehicul",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Oferta_ClientID",
                table: "Oferta",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Oferta_VehiculID",
                table: "Oferta",
                column: "VehiculID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Oferta");

            migrationBuilder.AlterColumn<string>(
                name: "CodPostal",
                table: "Client",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
