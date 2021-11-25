using Microsoft.EntityFrameworkCore.Migrations;

namespace Opgave4.Migrations
{
    public partial class Opgave4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_societies_municipalities_municipalityzipCode1",
                table: "societies");

            migrationBuilder.RenameColumn(
                name: "municipalityzipCode1",
                table: "societies",
                newName: "keyResponsibleId");

            migrationBuilder.RenameIndex(
                name: "IX_societies_municipalityzipCode1",
                table: "societies",
                newName: "IX_societies_keyResponsibleId");

            migrationBuilder.AlterColumn<int>(
                name: "municipalityzipCode",
                table: "societies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "timespanId",
                table: "roomBookings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "zipCode",
                table: "municipalities",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "accessKeyId",
                table: "locations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "accessKeys",
                columns: table => new
                {
                    accessKeyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    keyAddressaddressId = table.Column<int>(type: "int", nullable: true),
                    addressId = table.Column<int>(type: "int", nullable: false),
                    pinCode = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accessKeys", x => x.accessKeyId);
                    table.ForeignKey(
                        name: "FK_accessKeys_addresses_keyAddressaddressId",
                        column: x => x.keyAddressaddressId,
                        principalTable: "addresses",
                        principalColumn: "addressId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "keyResponsibles",
                columns: table => new
                {
                    keyResponsibleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    personcpr = table.Column<string>(type: "nvarchar(11)", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    licenseNumber = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_keyResponsibles", x => x.keyResponsibleId);
                    table.ForeignKey(
                        name: "FK_keyResponsibles_persons_personcpr",
                        column: x => x.personcpr,
                        principalTable: "persons",
                        principalColumn: "cpr",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_societies_municipalityzipCode",
                table: "societies",
                column: "municipalityzipCode");

            migrationBuilder.CreateIndex(
                name: "IX_locations_accessKeyId",
                table: "locations",
                column: "accessKeyId");

            migrationBuilder.CreateIndex(
                name: "IX_accessKeys_keyAddressaddressId",
                table: "accessKeys",
                column: "keyAddressaddressId");

            migrationBuilder.CreateIndex(
                name: "IX_keyResponsibles_personcpr",
                table: "keyResponsibles",
                column: "personcpr");

            migrationBuilder.AddForeignKey(
                name: "FK_locations_accessKeys_accessKeyId",
                table: "locations",
                column: "accessKeyId",
                principalTable: "accessKeys",
                principalColumn: "accessKeyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_societies_keyResponsibles_keyResponsibleId",
                table: "societies",
                column: "keyResponsibleId",
                principalTable: "keyResponsibles",
                principalColumn: "keyResponsibleId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_societies_municipalities_municipalityzipCode",
                table: "societies",
                column: "municipalityzipCode",
                principalTable: "municipalities",
                principalColumn: "zipCode",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_locations_accessKeys_accessKeyId",
                table: "locations");

            migrationBuilder.DropForeignKey(
                name: "FK_societies_keyResponsibles_keyResponsibleId",
                table: "societies");

            migrationBuilder.DropForeignKey(
                name: "FK_societies_municipalities_municipalityzipCode",
                table: "societies");

            migrationBuilder.DropTable(
                name: "accessKeys");

            migrationBuilder.DropTable(
                name: "keyResponsibles");

            migrationBuilder.DropIndex(
                name: "IX_societies_municipalityzipCode",
                table: "societies");

            migrationBuilder.DropIndex(
                name: "IX_locations_accessKeyId",
                table: "locations");

            migrationBuilder.DropColumn(
                name: "accessKeyId",
                table: "locations");

            migrationBuilder.RenameColumn(
                name: "keyResponsibleId",
                table: "societies",
                newName: "municipalityzipCode1");

            migrationBuilder.RenameIndex(
                name: "IX_societies_keyResponsibleId",
                table: "societies",
                newName: "IX_societies_municipalityzipCode1");

            migrationBuilder.AlterColumn<string>(
                name: "municipalityzipCode",
                table: "societies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "timespanId",
                table: "roomBookings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "zipCode",
                table: "municipalities",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_societies_municipalities_municipalityzipCode1",
                table: "societies",
                column: "municipalityzipCode1",
                principalTable: "municipalities",
                principalColumn: "zipCode",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
