using Microsoft.EntityFrameworkCore.Migrations;

namespace Eroski.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Eroski",
                columns: table => new
                {
                    seccion = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ticket = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eroski", x => x.seccion);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Eroski");
        }
    }
}
