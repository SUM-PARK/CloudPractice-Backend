using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Itinere.Infrastructure.Migrations
{
    public partial class coffeetime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CoffeeTime",
                columns: table => new
                {
                    With = table.Column<string>(nullable: true),
                    When = table.Column<DateTime>(nullable: false),
                    FootprintId = table.Column<string>(nullable: true),
                    _id = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoffeeTime", x => x._id);
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
        }
    }
}
