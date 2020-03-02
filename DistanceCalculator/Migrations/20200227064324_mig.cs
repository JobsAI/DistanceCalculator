using Microsoft.EntityFrameworkCore.Migrations;

namespace DistanceCalculator.Migrations
{
    public partial class mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "geoPoints",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City1 = table.Column<string>(nullable: true),
                    Longitude1 = table.Column<double>(nullable: false),
                    Latitude1 = table.Column<double>(nullable: false),
                    City2 = table.Column<string>(nullable: true),
                    Longitude2 = table.Column<double>(nullable: false),
                    Latitude2 = table.Column<double>(nullable: false),
                    Distance = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_geoPoints", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "geoPoints");
        }
    }
}
