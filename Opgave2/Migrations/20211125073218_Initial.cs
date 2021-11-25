using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Opgave2.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "addresses",
                columns: table => new
                {
                    addressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    number = table.Column<int>(type: "int", nullable: false),
                    postalCode = table.Column<int>(type: "int", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_addresses", x => x.addressId);
                });

            migrationBuilder.CreateTable(
                name: "municipalities",
                columns: table => new
                {
                    zipCode = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_municipalities", x => x.zipCode);
                });

            migrationBuilder.CreateTable(
                name: "persons",
                columns: table => new
                {
                    cpr = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    addressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_persons", x => x.cpr);
                    table.ForeignKey(
                        name: "FK_persons_addresses_addressId",
                        column: x => x.addressId,
                        principalTable: "addresses",
                        principalColumn: "addressId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "locations",
                columns: table => new
                {
                    locationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    municipalityzipCode = table.Column<int>(type: "int", nullable: false),
                    addressId = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_locations", x => x.locationId);
                    table.ForeignKey(
                        name: "FK_locations_addresses_addressId",
                        column: x => x.addressId,
                        principalTable: "addresses",
                        principalColumn: "addressId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_locations_municipalities_municipalityzipCode",
                        column: x => x.municipalityzipCode,
                        principalTable: "municipalities",
                        principalColumn: "zipCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "societies",
                columns: table => new
                {
                    cvr = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    activity = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    addressId = table.Column<int>(type: "int", nullable: false),
                    municipalityzipCode1 = table.Column<int>(type: "int", nullable: false),
                    municipalityzipCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_societies", x => x.cvr);
                    table.ForeignKey(
                        name: "FK_societies_addresses_addressId",
                        column: x => x.addressId,
                        principalTable: "addresses",
                        principalColumn: "addressId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_societies_municipalities_municipalityzipCode1",
                        column: x => x.municipalityzipCode1,
                        principalTable: "municipalities",
                        principalColumn: "zipCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "properties",
                columns: table => new
                {
                    propertyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    locationId = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_properties", x => x.propertyId);
                    table.ForeignKey(
                        name: "FK_properties_locations_locationId",
                        column: x => x.locationId,
                        principalTable: "locations",
                        principalColumn: "locationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "rooms",
                columns: table => new
                {
                    roomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    locationId = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rooms", x => x.roomId);
                    table.ForeignKey(
                        name: "FK_rooms_locations_locationId",
                        column: x => x.locationId,
                        principalTable: "locations",
                        principalColumn: "locationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "memberships",
                columns: table => new
                {
                    membershipId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    societycvr = table.Column<string>(type: "nvarchar(8)", nullable: true),
                    personcpr = table.Column<string>(type: "nvarchar(11)", nullable: false),
                    isChairman = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_memberships", x => x.membershipId);
                    table.ForeignKey(
                        name: "FK_memberships_persons_personcpr",
                        column: x => x.personcpr,
                        principalTable: "persons",
                        principalColumn: "cpr",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_memberships_societies_societycvr",
                        column: x => x.societycvr,
                        principalTable: "societies",
                        principalColumn: "cvr",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "timespans",
                columns: table => new
                {
                    timespanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    openingTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    closingTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    roomId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_timespans", x => x.timespanId);
                    table.ForeignKey(
                        name: "FK_timespans_rooms_roomId",
                        column: x => x.roomId,
                        principalTable: "rooms",
                        principalColumn: "roomId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "roomBookings",
                columns: table => new
                {
                    roomBookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    societiecvr = table.Column<string>(type: "nvarchar(8)", nullable: true),
                    timespanId = table.Column<int>(type: "int", nullable: true),
                    description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roomBookings", x => x.roomBookingId);
                    table.ForeignKey(
                        name: "FK_roomBookings_societies_societiecvr",
                        column: x => x.societiecvr,
                        principalTable: "societies",
                        principalColumn: "cvr",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_roomBookings_timespans_timespanId",
                        column: x => x.timespanId,
                        principalTable: "timespans",
                        principalColumn: "timespanId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PropertiesRoomBookings",
                columns: table => new
                {
                    propertiespropertyId = table.Column<int>(type: "int", nullable: false),
                    roomBookingsroomBookingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertiesRoomBookings", x => new { x.propertiespropertyId, x.roomBookingsroomBookingId });
                    table.ForeignKey(
                        name: "FK_PropertiesRoomBookings_properties_propertiespropertyId",
                        column: x => x.propertiespropertyId,
                        principalTable: "properties",
                        principalColumn: "propertyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PropertiesRoomBookings_roomBookings_roomBookingsroomBookingId",
                        column: x => x.roomBookingsroomBookingId,
                        principalTable: "roomBookings",
                        principalColumn: "roomBookingId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_locations_addressId",
                table: "locations",
                column: "addressId");

            migrationBuilder.CreateIndex(
                name: "IX_locations_municipalityzipCode",
                table: "locations",
                column: "municipalityzipCode");

            migrationBuilder.CreateIndex(
                name: "IX_memberships_personcpr",
                table: "memberships",
                column: "personcpr");

            migrationBuilder.CreateIndex(
                name: "IX_memberships_societycvr",
                table: "memberships",
                column: "societycvr");

            migrationBuilder.CreateIndex(
                name: "IX_persons_addressId",
                table: "persons",
                column: "addressId");

            migrationBuilder.CreateIndex(
                name: "IX_properties_locationId",
                table: "properties",
                column: "locationId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertiesRoomBookings_roomBookingsroomBookingId",
                table: "PropertiesRoomBookings",
                column: "roomBookingsroomBookingId");

            migrationBuilder.CreateIndex(
                name: "IX_roomBookings_societiecvr",
                table: "roomBookings",
                column: "societiecvr");

            migrationBuilder.CreateIndex(
                name: "IX_roomBookings_timespanId",
                table: "roomBookings",
                column: "timespanId");

            migrationBuilder.CreateIndex(
                name: "IX_rooms_locationId",
                table: "rooms",
                column: "locationId");

            migrationBuilder.CreateIndex(
                name: "IX_societies_addressId",
                table: "societies",
                column: "addressId");

            migrationBuilder.CreateIndex(
                name: "IX_societies_municipalityzipCode1",
                table: "societies",
                column: "municipalityzipCode1");

            migrationBuilder.CreateIndex(
                name: "IX_timespans_roomId",
                table: "timespans",
                column: "roomId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "memberships");

            migrationBuilder.DropTable(
                name: "PropertiesRoomBookings");

            migrationBuilder.DropTable(
                name: "persons");

            migrationBuilder.DropTable(
                name: "properties");

            migrationBuilder.DropTable(
                name: "roomBookings");

            migrationBuilder.DropTable(
                name: "societies");

            migrationBuilder.DropTable(
                name: "timespans");

            migrationBuilder.DropTable(
                name: "rooms");

            migrationBuilder.DropTable(
                name: "locations");

            migrationBuilder.DropTable(
                name: "addresses");

            migrationBuilder.DropTable(
                name: "municipalities");
        }
    }
}
