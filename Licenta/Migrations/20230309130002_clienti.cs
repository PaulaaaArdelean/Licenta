﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Licenta.Migrations
{
    public partial class clienti : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CNP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeProprietar = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PrenumeProprietar = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    SerieCI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumarCI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CUI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActivitateSocietate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeFirma = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    NumeReprezentantFirma = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PrenumeReprezentantFirma = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Judet = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Localitate = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Strada = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Numar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodPostal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}
