using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Opgave4.Migrations
{
    public partial class MoreRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "addresses",
                columns: table => new
                {
                    addressId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    street = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    number = table.Column<int>(type: "INTEGER", nullable: false),
                    postalCode = table.Column<int>(type: "INTEGER", maxLength: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_addresses", x => x.addressId);
                });

            migrationBuilder.CreateTable(
                name: "municipalities",
                columns: table => new
                {
                    zipCode = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_municipalities", x => x.zipCode);
                });

            migrationBuilder.CreateTable(
                name: "accessKeys",
                columns: table => new
                {
                    accessKeyId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    keyAddressaddressId = table.Column<int>(type: "INTEGER", nullable: true),
                    addressId = table.Column<int>(type: "INTEGER", nullable: false),
                    pinCode = table.Column<string>(type: "TEXT", maxLength: 8, nullable: true)
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
                name: "persons",
                columns: table => new
                {
                    cpr = table.Column<string>(type: "TEXT", maxLength: 11, nullable: false),
                    name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    addressId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_persons", x => x.cpr);
                    table.ForeignKey(
                        name: "FK_persons_addresses_addressId",
                        column: x => x.addressId,
                        principalTable: "addresses",
                        principalColumn: "addressId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "locations",
                columns: table => new
                {
                    locationId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    municipalityzipCode = table.Column<int>(type: "INTEGER", nullable: false),
                    addressId = table.Column<int>(type: "INTEGER", nullable: false),
                    accessKeyId = table.Column<int>(type: "INTEGER", nullable: false),
                    description = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_locations", x => x.locationId);
                    table.ForeignKey(
                        name: "FK_locations_accessKeys_accessKeyId",
                        column: x => x.accessKeyId,
                        principalTable: "accessKeys",
                        principalColumn: "accessKeyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_locations_addresses_addressId",
                        column: x => x.addressId,
                        principalTable: "addresses",
                        principalColumn: "addressId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_locations_municipalities_municipalityzipCode",
                        column: x => x.municipalityzipCode,
                        principalTable: "municipalities",
                        principalColumn: "zipCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "keyResponsibles",
                columns: table => new
                {
                    keyResponsibleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    personcpr = table.Column<string>(type: "TEXT", nullable: true),
                    phone = table.Column<string>(type: "TEXT", maxLength: 8, nullable: true),
                    licenseNumber = table.Column<string>(type: "TEXT", maxLength: 8, nullable: true)
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

            migrationBuilder.CreateTable(
                name: "properties",
                columns: table => new
                {
                    propertyId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    locationId = table.Column<int>(type: "INTEGER", nullable: false),
                    description = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_properties", x => x.propertyId);
                    table.ForeignKey(
                        name: "FK_properties_locations_locationId",
                        column: x => x.locationId,
                        principalTable: "locations",
                        principalColumn: "locationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "rooms",
                columns: table => new
                {
                    roomId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    locationId = table.Column<int>(type: "INTEGER", nullable: false),
                    name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    capacity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rooms", x => x.roomId);
                    table.ForeignKey(
                        name: "FK_rooms_locations_locationId",
                        column: x => x.locationId,
                        principalTable: "locations",
                        principalColumn: "locationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "societies",
                columns: table => new
                {
                    cvr = table.Column<string>(type: "TEXT", maxLength: 8, nullable: false),
                    name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    activity = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    addressId = table.Column<int>(type: "INTEGER", nullable: false),
                    keyResponsibleId = table.Column<int>(type: "INTEGER", nullable: false),
                    municipalityzipCode = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_societies", x => x.cvr);
                    table.ForeignKey(
                        name: "FK_societies_addresses_addressId",
                        column: x => x.addressId,
                        principalTable: "addresses",
                        principalColumn: "addressId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_societies_keyResponsibles_keyResponsibleId",
                        column: x => x.keyResponsibleId,
                        principalTable: "keyResponsibles",
                        principalColumn: "keyResponsibleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_societies_municipalities_municipalityzipCode",
                        column: x => x.municipalityzipCode,
                        principalTable: "municipalities",
                        principalColumn: "zipCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "timespans",
                columns: table => new
                {
                    timespanId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    openingTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    closingTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    roomId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_timespans", x => x.timespanId);
                    table.ForeignKey(
                        name: "FK_timespans_rooms_roomId",
                        column: x => x.roomId,
                        principalTable: "rooms",
                        principalColumn: "roomId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "memberships",
                columns: table => new
                {
                    membershipId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    societycvr = table.Column<string>(type: "TEXT", nullable: false),
                    personcpr = table.Column<string>(type: "TEXT", nullable: true),
                    isChairman = table.Column<bool>(type: "INTEGER", nullable: false)
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "roomBookings",
                columns: table => new
                {
                    roomBookingId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    societiecvr = table.Column<string>(type: "TEXT", nullable: true),
                    timespanId = table.Column<int>(type: "INTEGER", nullable: false),
                    description = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roomBookings", x => x.roomBookingId);
                    table.ForeignKey(
                        name: "FK_roomBookings_societies_societiecvr",
                        column: x => x.societiecvr,
                        principalTable: "societies",
                        principalColumn: "cvr",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_roomBookings_timespans_timespanId",
                        column: x => x.timespanId,
                        principalTable: "timespans",
                        principalColumn: "timespanId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_accessKeys_keyAddressaddressId",
                table: "accessKeys",
                column: "keyAddressaddressId");

            migrationBuilder.CreateIndex(
                name: "IX_keyResponsibles_personcpr",
                table: "keyResponsibles",
                column: "personcpr");

            migrationBuilder.CreateIndex(
                name: "IX_locations_accessKeyId",
                table: "locations",
                column: "accessKeyId");

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
                name: "IX_societies_keyResponsibleId",
                table: "societies",
                column: "keyResponsibleId");

            migrationBuilder.CreateIndex(
                name: "IX_societies_municipalityzipCode",
                table: "societies",
                column: "municipalityzipCode");

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
                name: "properties");

            migrationBuilder.DropTable(
                name: "roomBookings");

            migrationBuilder.DropTable(
                name: "societies");

            migrationBuilder.DropTable(
                name: "timespans");

            migrationBuilder.DropTable(
                name: "keyResponsibles");

            migrationBuilder.DropTable(
                name: "rooms");

            migrationBuilder.DropTable(
                name: "persons");

            migrationBuilder.DropTable(
                name: "locations");

            migrationBuilder.DropTable(
                name: "accessKeys");

            migrationBuilder.DropTable(
                name: "municipalities");

            migrationBuilder.DropTable(
                name: "addresses");
        }
    }
}
