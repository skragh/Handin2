using Microsoft.EntityFrameworkCore.Migrations;

namespace Opgave2.Migrations
{
    public partial class InitialMigration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_locations_addresses_AddressId",
                table: "locations");

            migrationBuilder.DropForeignKey(
                name: "FK_persons_addresses_AddressId",
                table: "persons");

            migrationBuilder.DropForeignKey(
                name: "FK_societies_addresses_AddressId",
                table: "societies");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "societies",
                newName: "addressId");

            migrationBuilder.RenameIndex(
                name: "IX_societies_AddressId",
                table: "societies",
                newName: "IX_societies_addressId");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "persons",
                newName: "addressId");

            migrationBuilder.RenameIndex(
                name: "IX_persons_AddressId",
                table: "persons",
                newName: "IX_persons_addressId");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "locations",
                newName: "addressId");

            migrationBuilder.RenameIndex(
                name: "IX_locations_AddressId",
                table: "locations",
                newName: "IX_locations_addressId");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "addresses",
                newName: "addressId");

            migrationBuilder.AddForeignKey(
                name: "FK_locations_addresses_addressId",
                table: "locations",
                column: "addressId",
                principalTable: "addresses",
                principalColumn: "addressId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_persons_addresses_addressId",
                table: "persons",
                column: "addressId",
                principalTable: "addresses",
                principalColumn: "addressId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_societies_addresses_addressId",
                table: "societies",
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

            migrationBuilder.DropForeignKey(
                name: "FK_persons_addresses_addressId",
                table: "persons");

            migrationBuilder.DropForeignKey(
                name: "FK_societies_addresses_addressId",
                table: "societies");

            migrationBuilder.RenameColumn(
                name: "addressId",
                table: "societies",
                newName: "AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_societies_addressId",
                table: "societies",
                newName: "IX_societies_AddressId");

            migrationBuilder.RenameColumn(
                name: "addressId",
                table: "persons",
                newName: "AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_persons_addressId",
                table: "persons",
                newName: "IX_persons_AddressId");

            migrationBuilder.RenameColumn(
                name: "addressId",
                table: "locations",
                newName: "AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_locations_addressId",
                table: "locations",
                newName: "IX_locations_AddressId");

            migrationBuilder.RenameColumn(
                name: "addressId",
                table: "addresses",
                newName: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_locations_addresses_AddressId",
                table: "locations",
                column: "AddressId",
                principalTable: "addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_persons_addresses_AddressId",
                table: "persons",
                column: "AddressId",
                principalTable: "addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_societies_addresses_AddressId",
                table: "societies",
                column: "AddressId",
                principalTable: "addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
