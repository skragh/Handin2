using Microsoft.EntityFrameworkCore.Migrations;

namespace Opgave2.Migrations
{
    public partial class InitialMigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_properties_roomBookings_RoomBookingsroomBookingId",
                table: "properties");

            migrationBuilder.DropForeignKey(
                name: "FK_societies_addresses_AddressId",
                table: "societies");

            migrationBuilder.DropIndex(
                name: "IX_properties_RoomBookingsroomBookingId",
                table: "properties");

            migrationBuilder.DropColumn(
                name: "RoomBookingsroomBookingId",
                table: "properties");

            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "societies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "PropertiesRoomBookings",
                columns: table => new
                {
                    propertiespropertyId = table.Column<int>(type: "INTEGER", nullable: false),
                    roomBookingsroomBookingId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertiesRoomBookings", x => new { x.propertiespropertyId, x.roomBookingsroomBookingId });
                    table.ForeignKey(
                        name: "FK_PropertiesRoomBookings_properties_propertiespropertyId",
                        column: x => x.propertiespropertyId,
                        principalTable: "properties",
                        principalColumn: "propertyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertiesRoomBookings_roomBookings_roomBookingsroomBookingId",
                        column: x => x.roomBookingsroomBookingId,
                        principalTable: "roomBookings",
                        principalColumn: "roomBookingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PropertiesRoomBookings_roomBookingsroomBookingId",
                table: "PropertiesRoomBookings",
                column: "roomBookingsroomBookingId");

            migrationBuilder.AddForeignKey(
                name: "FK_societies_addresses_AddressId",
                table: "societies",
                column: "AddressId",
                principalTable: "addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_societies_addresses_AddressId",
                table: "societies");

            migrationBuilder.DropTable(
                name: "PropertiesRoomBookings");

            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "societies",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "RoomBookingsroomBookingId",
                table: "properties",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_properties_RoomBookingsroomBookingId",
                table: "properties",
                column: "RoomBookingsroomBookingId");

            migrationBuilder.AddForeignKey(
                name: "FK_properties_roomBookings_RoomBookingsroomBookingId",
                table: "properties",
                column: "RoomBookingsroomBookingId",
                principalTable: "roomBookings",
                principalColumn: "roomBookingId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_societies_addresses_AddressId",
                table: "societies",
                column: "AddressId",
                principalTable: "addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
