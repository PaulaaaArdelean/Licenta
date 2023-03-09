using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Licenta.Migrations
{
    public partial class tipurisocietate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipSocietateID",
                table: "Client",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TipSocietate",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipulSocietate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipSocietate", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Client_TipSocietateID",
                table: "Client",
                column: "TipSocietateID");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_TipSocietate_TipSocietateID",
                table: "Client",
                column: "TipSocietateID",
                principalTable: "TipSocietate",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_TipSocietate_TipSocietateID",
                table: "Client");

            migrationBuilder.DropTable(
                name: "TipSocietate");

            migrationBuilder.DropIndex(
                name: "IX_Client_TipSocietateID",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "TipSocietateID",
                table: "Client");
        }
    }
}
