using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Licenta.Migrations
{
    public partial class vehicule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicul",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumarIdentificare = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NrInmatriculare = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnFabricatie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CapacitateCilindrica = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SerieCIV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NrLocuri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MasaMaxima = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Putere = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicul", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicul");
        }
    }
}
