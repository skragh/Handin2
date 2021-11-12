using Microsoft.EntityFrameworkCore.Migrations;

namespace Opgave2.Migrations
{
    public partial class MoreIDs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_persons_addresses_addressId",
                table: "persons");

            migrationBuilder.DropForeignKey(
                name: "FK_roomBookings_timespans_timespanId",
                table: "roomBookings");

            migrationBuilder.DropForeignKey(
                name: "FK_timespans_rooms_roomId",
                table: "timespans");

            migrationBuilder.AlterColumn<int>(
                name: "roomId",
                table: "timespans",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "zipCode",
                table: "societies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "timespanId",
                table: "roomBookings",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cvr",
                table: "roomBookings",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "addressId",
                table: "persons",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_persons_addresses_addressId",
                table: "persons",
                column: "addressId",
                principalTable: "addresses",
                principalColumn: "addressId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_roomBookings_timespans_timespanId",
                table: "roomBookings",
                column: "timespanId",
                principalTable: "timespans",
                principalColumn: "timespanId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_timespans_rooms_roomId",
                table: "timespans",
                column: "roomId",
                principalTable: "rooms",
                principalColumn: "roomId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_persons_addresses_addressId",
                table: "persons");

            migrationBuilder.DropForeignKey(
                name: "FK_roomBookings_timespans_timespanId",
                table: "roomBookings");

            migrationBuilder.DropForeignKey(
                name: "FK_timespans_rooms_roomId",
                table: "timespans");

            migrationBuilder.DropColumn(
                name: "zipCode",
                table: "societies");

            migrationBuilder.DropColumn(
                name: "cvr",
                table: "roomBookings");

            migrationBuilder.AlterColumn<int>(
                name: "roomId",
                table: "timespans",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "timespanId",
                table: "roomBookings",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "addressId",
                table: "persons",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_persons_addresses_addressId",
                table: "persons",
                column: "addressId",
                principalTable: "addresses",
                principalColumn: "addressId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_roomBookings_timespans_timespanId",
                table: "roomBookings",
                column: "timespanId",
                principalTable: "timespans",
                principalColumn: "timespanId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_timespans_rooms_roomId",
                table: "timespans",
                column: "roomId",
                principalTable: "rooms",
                principalColumn: "roomId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
