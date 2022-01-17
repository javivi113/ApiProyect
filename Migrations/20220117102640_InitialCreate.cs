using Microsoft.EntityFrameworkCore.Migrations;

namespace Tiempo.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tiempo",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Municipio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Provincia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GpxX = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GpxY = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Temperatura = table.Column<int>(type: "int", nullable: false),
                    VelViento = table.Column<int>(type: "int", nullable: false),
                    Humedad = table.Column<int>(type: "int", nullable: false),
                    Precipitaciones = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tiempo", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tiempo");
        }
    }
}
