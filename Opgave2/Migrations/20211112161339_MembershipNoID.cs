using Microsoft.EntityFrameworkCore.Migrations;

namespace Opgave2.Migrations
{
    public partial class MembershipNoID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cpr",
                table: "memberships");

            migrationBuilder.DropColumn(
                name: "cvr",
                table: "memberships");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
