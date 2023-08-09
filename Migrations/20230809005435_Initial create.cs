using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Employees.Migrations
{
    public partial class Initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Oddeli",
                columns: table => new
                {
                    OddelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImeOddel = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    BrojVraboteni = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oddeli", x => x.OddelId);
                });

            migrationBuilder.CreateTable(
                name: "Vraboteni",
                columns: table => new
                {
                    VrabotenId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    Plata = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OddelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vraboteni", x => x.VrabotenId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Oddeli");

            migrationBuilder.DropTable(
                name: "Vraboteni");
        }
    }
}
