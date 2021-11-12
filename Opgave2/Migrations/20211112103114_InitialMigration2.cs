using Microsoft.EntityFrameworkCore.Migrations;

namespace Opgave2.Migrations
{
    public partial class InitialMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_properties_locations_locationId",
                table: "properties");

            migrationBuilder.AlterColumn<int>(
                name: "locationId",
                table: "properties",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_properties_locations_locationId",
                table: "properties",
                column: "locationId",
                principalTable: "locations",
                principalColumn: "locationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_properties_locations_locationId",
                table: "properties");

            migrationBuilder.AlterColumn<int>(
                name: "locationId",
                table: "properties",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_properties_locations_locationId",
                table: "properties",
                column: "locationId",
                principalTable: "locations",
                principalColumn: "locationId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
