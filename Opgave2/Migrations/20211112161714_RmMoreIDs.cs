using Microsoft.EntityFrameworkCore.Migrations;

namespace Opgave2.Migrations
{
    public partial class RmMoreIDs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "zipCode",
                table: "societies");

            migrationBuilder.DropColumn(
                name: "zipCode",
                table: "locations");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "zipCode",
                table: "societies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "zipCode",
                table: "locations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
