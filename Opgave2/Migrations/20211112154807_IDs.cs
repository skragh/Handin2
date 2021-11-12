using Microsoft.EntityFrameworkCore.Migrations;

namespace Opgave2.Migrations
{
    public partial class IDs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_locations_addresses_addressId",
                table: "locations");

            migrationBuilder.AddColumn<string>(
                name: "cpr",
                table: "memberships",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cvr",
                table: "memberships",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "addressId",
                table: "locations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "zipCode",
                table: "locations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_locations_addresses_addressId",
                table: "locations",
                column: "addressId",
                principalTable: "addresses",
                principalColumn: "addressId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_locations_addresses_addressId",
                table: "locations");

            migrationBuilder.DropColumn(
                name: "cpr",
                table: "memberships");

            migrationBuilder.DropColumn(
                name: "cvr",
                table: "memberships");

            migrationBuilder.DropColumn(
                name: "zipCode",
                table: "locations");

            migrationBuilder.AlterColumn<int>(
                name: "addressId",
                table: "locations",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_locations_addresses_addressId",
                table: "locations",
                column: "addressId",
                principalTable: "addresses",
                principalColumn: "addressId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
