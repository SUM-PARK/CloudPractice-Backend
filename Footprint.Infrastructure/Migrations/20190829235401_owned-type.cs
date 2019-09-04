using Microsoft.EntityFrameworkCore.Migrations;

namespace Itinere.Infrastructure.Migrations
{
    public partial class ownedtype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MorningDung_Description",
                table: "Footprints",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MorningDung_Solidity",
                table: "Footprints",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MorningDung_Description",
                table: "Footprints");

            migrationBuilder.DropColumn(
                name: "MorningDung_Solidity",
                table: "Footprints");
        }
    }
}
