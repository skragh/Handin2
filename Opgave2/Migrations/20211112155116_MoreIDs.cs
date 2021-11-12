using Microsoft.EntityFrameworkCore.Migrations;

namespace Opgave2.Migrations
{
    public partial class MoreIDs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_roomBookings_timespans_timespanId",
                table: "roomBookings");

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

            migrationBuilder.AddForeignKey(
                name: "FK_roomBookings_timespans_timespanId",
                table: "roomBookings",
                column: "timespanId",
                principalTable: "timespans",
                principalColumn: "timespanId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_roomBookings_timespans_timespanId",
                table: "roomBookings");

            migrationBuilder.DropColumn(
                name: "cvr",
                table: "roomBookings");

            migrationBuilder.AlterColumn<int>(
                name: "timespanId",
                table: "roomBookings",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_roomBookings_timespans_timespanId",
                table: "roomBookings",
                column: "timespanId",
                principalTable: "timespans",
                principalColumn: "timespanId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
