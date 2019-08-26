using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Itinere.Infrastructure.Migrations
{
    public partial class ownedtype_dung : Migration
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

            migrationBuilder.CreateTable(
                name: "CoffeeTime",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    With = table.Column<string>(nullable: true),
                    When = table.Column<DateTime>(nullable: false),
                    FootprintId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoffeeTime", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoffeeTime_Footprints_FootprintId",
                        column: x => x.FootprintId,
                        principalTable: "Footprints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CoffeeTime_FootprintId",
                table: "CoffeeTime",
                column: "FootprintId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoffeeTime");

            migrationBuilder.DropColumn(
                name: "MorningDung_Description",
                table: "Footprints");

            migrationBuilder.DropColumn(
                name: "MorningDung_Solidity",
                table: "Footprints");
        }
    }
}
