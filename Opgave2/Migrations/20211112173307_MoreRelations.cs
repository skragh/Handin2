using Microsoft.EntityFrameworkCore.Migrations;

namespace Opgave2.Migrations
{
    public partial class MoreRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_locations_municipalities_municipalityzipCode",
                table: "locations");

            migrationBuilder.DropForeignKey(
                name: "FK_memberships_persons_personcpr",
                table: "memberships");

            migrationBuilder.DropForeignKey(
                name: "FK_societies_municipalities_municipalityzipCode",
                table: "societies");

            migrationBuilder.DropIndex(
                name: "IX_societies_municipalityzipCode",
                table: "societies");

            migrationBuilder.DropColumn(
                name: "zipCode",
                table: "locations");

            migrationBuilder.RenameColumn(
                name: "zipCode",
                table: "societies",
                newName: "municipalityzipCode1");

            migrationBuilder.AlterColumn<string>(
                name: "municipalityzipCode",
                table: "societies",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "societiecvr",
                table: "roomBookings",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "societycvr",
                table: "memberships",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "personcpr",
                table: "memberships",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "municipalityzipCode",
                table: "locations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_societies_municipalityzipCode1",
                table: "societies",
                column: "municipalityzipCode1");

            migrationBuilder.AddForeignKey(
                name: "FK_locations_municipalities_municipalityzipCode",
                table: "locations",
                column: "municipalityzipCode",
                principalTable: "municipalities",
                principalColumn: "zipCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_memberships_persons_personcpr",
                table: "memberships",
                column: "personcpr",
                principalTable: "persons",
                principalColumn: "cpr",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_societies_municipalities_municipalityzipCode1",
                table: "societies",
                column: "municipalityzipCode1",
                principalTable: "municipalities",
                principalColumn: "zipCode",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_locations_municipalities_municipalityzipCode",
                table: "locations");

            migrationBuilder.DropForeignKey(
                name: "FK_memberships_persons_personcpr",
                table: "memberships");

            migrationBuilder.DropForeignKey(
                name: "FK_societies_municipalities_municipalityzipCode1",
                table: "societies");

            migrationBuilder.DropIndex(
                name: "IX_societies_municipalityzipCode1",
                table: "societies");

            migrationBuilder.RenameColumn(
                name: "municipalityzipCode1",
                table: "societies",
                newName: "zipCode");

            migrationBuilder.AlterColumn<int>(
                name: "municipalityzipCode",
                table: "societies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "societiecvr",
                table: "roomBookings",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "societycvr",
                table: "memberships",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "personcpr",
                table: "memberships",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "municipalityzipCode",
                table: "locations",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "zipCode",
                table: "locations",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_societies_municipalityzipCode",
                table: "societies",
                column: "municipalityzipCode");

            migrationBuilder.AddForeignKey(
                name: "FK_locations_municipalities_municipalityzipCode",
                table: "locations",
                column: "municipalityzipCode",
                principalTable: "municipalities",
                principalColumn: "zipCode",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_memberships_persons_personcpr",
                table: "memberships",
                column: "personcpr",
                principalTable: "persons",
                principalColumn: "cpr",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_societies_municipalities_municipalityzipCode",
                table: "societies",
                column: "municipalityzipCode",
                principalTable: "municipalities",
                principalColumn: "zipCode",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
