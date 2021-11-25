﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Opgave4;

namespace Opgave4.Migrations
{
    [DbContext(typeof(MuncipalityDbContext))]
    partial class MuncipalityDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Opgave4.AccessKey", b =>
                {
                    b.Property<int>("accessKeyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("addressId")
                        .HasColumnType("int");

                    b.Property<int?>("keyAddressaddressId")
                        .HasColumnType("int");

                    b.Property<string>("pinCode")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.HasKey("accessKeyId");

                    b.HasIndex("keyAddressaddressId");

                    b.ToTable("accessKeys");
                });

            modelBuilder.Entity("Opgave4.Addresses", b =>
                {
                    b.Property<int>("addressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("number")
                        .HasColumnType("int");

                    b.Property<int>("postalCode")
                        .HasMaxLength(4)
                        .HasColumnType("int");

                    b.Property<string>("street")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("addressId");

                    b.ToTable("addresses");
                });

            modelBuilder.Entity("Opgave4.KeyResponsible", b =>
                {
                    b.Property<int>("keyResponsibleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("licenseNumber")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("personcpr")
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("phone")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.HasKey("keyResponsibleId");

                    b.HasIndex("personcpr");

                    b.ToTable("keyResponsibles");
                });

            modelBuilder.Entity("Opgave4.Locations", b =>
                {
                    b.Property<int>("locationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("accessKeyId")
                        .HasColumnType("int");

                    b.Property<int>("addressId")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("municipalityzipCode")
                        .HasColumnType("int");

                    b.HasKey("locationId");

                    b.HasIndex("accessKeyId");

                    b.HasIndex("addressId");

                    b.HasIndex("municipalityzipCode");

                    b.ToTable("locations");
                });

            modelBuilder.Entity("Opgave4.Memberships", b =>
                {
                    b.Property<int>("membershipId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("isChairman")
                        .HasColumnType("bit");

                    b.Property<string>("personcpr")
                        .IsRequired()
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("societycvr")
                        .HasColumnType("nvarchar(8)");

                    b.HasKey("membershipId");

                    b.HasIndex("personcpr");

                    b.HasIndex("societycvr");

                    b.ToTable("memberships");
                });

            modelBuilder.Entity("Opgave4.Municipalities", b =>
                {
                    b.Property<int>("zipCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("zipCode");

                    b.ToTable("municipalities");
                });

            modelBuilder.Entity("Opgave4.Persons", b =>
                {
                    b.Property<string>("cpr")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<int>("addressId")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("cpr");

                    b.HasIndex("addressId");

                    b.ToTable("persons");
                });

            modelBuilder.Entity("Opgave4.Properties", b =>
                {
                    b.Property<int>("propertyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("locationId")
                        .HasColumnType("int");

                    b.HasKey("propertyId");

                    b.HasIndex("locationId");

                    b.ToTable("properties");
                });

            modelBuilder.Entity("Opgave4.RoomBookings", b =>
                {
                    b.Property<int>("roomBookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("societiecvr")
                        .HasColumnType("nvarchar(8)");

                    b.Property<int>("timespanId")
                        .HasColumnType("int");

                    b.HasKey("roomBookingId");

                    b.HasIndex("societiecvr");

                    b.HasIndex("timespanId");

                    b.ToTable("roomBookings");
                });

            modelBuilder.Entity("Opgave4.Rooms", b =>
                {
                    b.Property<int>("roomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("capacity")
                        .HasColumnType("int");

                    b.Property<int>("locationId")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("roomId");

                    b.HasIndex("locationId");

                    b.ToTable("rooms");
                });

            modelBuilder.Entity("Opgave4.Societies", b =>
                {
                    b.Property<string>("cvr")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("activity")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("addressId")
                        .HasColumnType("int");

                    b.Property<int>("keyResponsibleId")
                        .HasColumnType("int");

                    b.Property<int>("municipalityzipCode")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("cvr");

                    b.HasIndex("addressId");

                    b.HasIndex("keyResponsibleId");

                    b.HasIndex("municipalityzipCode");

                    b.ToTable("societies");
                });

            modelBuilder.Entity("Opgave4.Timespans", b =>
                {
                    b.Property<int>("timespanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("closingTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("openingTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("roomId")
                        .HasColumnType("int");

                    b.HasKey("timespanId");

                    b.HasIndex("roomId");

                    b.ToTable("timespans");
                });

            modelBuilder.Entity("PropertiesRoomBookings", b =>
                {
                    b.Property<int>("propertiespropertyId")
                        .HasColumnType("int");

                    b.Property<int>("roomBookingsroomBookingId")
                        .HasColumnType("int");

                    b.HasKey("propertiespropertyId", "roomBookingsroomBookingId");

                    b.HasIndex("roomBookingsroomBookingId");

                    b.ToTable("PropertiesRoomBookings");
                });

            modelBuilder.Entity("Opgave4.AccessKey", b =>
                {
                    b.HasOne("Opgave4.Addresses", "keyAddress")
                        .WithMany()
                        .HasForeignKey("keyAddressaddressId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("keyAddress");
                });

            modelBuilder.Entity("Opgave4.KeyResponsible", b =>
                {
                    b.HasOne("Opgave4.Persons", "person")
                        .WithMany()
                        .HasForeignKey("personcpr")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("person");
                });

            modelBuilder.Entity("Opgave4.Locations", b =>
                {
                    b.HasOne("Opgave4.AccessKey", "accessKey")
                        .WithMany()
                        .HasForeignKey("accessKeyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Opgave4.Addresses", "address")
                        .WithMany()
                        .HasForeignKey("addressId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Opgave4.Municipalities", "municipality")
                        .WithMany("locations")
                        .HasForeignKey("municipalityzipCode")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("accessKey");

                    b.Navigation("address");

                    b.Navigation("municipality");
                });

            modelBuilder.Entity("Opgave4.Memberships", b =>
                {
                    b.HasOne("Opgave4.Persons", "person")
                        .WithMany()
                        .HasForeignKey("personcpr")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Opgave4.Societies", "society")
                        .WithMany("memberships")
                        .HasForeignKey("societycvr")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("person");

                    b.Navigation("society");
                });

            modelBuilder.Entity("Opgave4.Persons", b =>
                {
                    b.HasOne("Opgave4.Addresses", "address")
                        .WithMany()
                        .HasForeignKey("addressId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("address");
                });

            modelBuilder.Entity("Opgave4.Properties", b =>
                {
                    b.HasOne("Opgave4.Locations", "location")
                        .WithMany("properties")
                        .HasForeignKey("locationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("location");
                });

            modelBuilder.Entity("Opgave4.RoomBookings", b =>
                {
                    b.HasOne("Opgave4.Societies", "societie")
                        .WithMany("roomBookings")
                        .HasForeignKey("societiecvr")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Opgave4.Timespans", "timespan")
                        .WithMany()
                        .HasForeignKey("timespanId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("societie");

                    b.Navigation("timespan");
                });

            modelBuilder.Entity("Opgave4.Rooms", b =>
                {
                    b.HasOne("Opgave4.Locations", "location")
                        .WithMany("rooms")
                        .HasForeignKey("locationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("location");
                });

            modelBuilder.Entity("Opgave4.Societies", b =>
                {
                    b.HasOne("Opgave4.Addresses", "address")
                        .WithMany()
                        .HasForeignKey("addressId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Opgave4.KeyResponsible", "keyResponsible")
                        .WithMany()
                        .HasForeignKey("keyResponsibleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Opgave4.Municipalities", "municipality")
                        .WithMany("societies")
                        .HasForeignKey("municipalityzipCode")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("address");

                    b.Navigation("keyResponsible");

                    b.Navigation("municipality");
                });

            modelBuilder.Entity("Opgave4.Timespans", b =>
                {
                    b.HasOne("Opgave4.Rooms", "room")
                        .WithMany("timespans")
                        .HasForeignKey("roomId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("room");
                });

            modelBuilder.Entity("PropertiesRoomBookings", b =>
                {
                    b.HasOne("Opgave4.Properties", null)
                        .WithMany()
                        .HasForeignKey("propertiespropertyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Opgave4.RoomBookings", null)
                        .WithMany()
                        .HasForeignKey("roomBookingsroomBookingId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Opgave4.Locations", b =>
                {
                    b.Navigation("properties");

                    b.Navigation("rooms");
                });

            modelBuilder.Entity("Opgave4.Municipalities", b =>
                {
                    b.Navigation("locations");

                    b.Navigation("societies");
                });

            modelBuilder.Entity("Opgave4.Rooms", b =>
                {
                    b.Navigation("timespans");
                });

            modelBuilder.Entity("Opgave4.Societies", b =>
                {
                    b.Navigation("memberships");

                    b.Navigation("roomBookings");
                });
#pragma warning restore 612, 618
        }
    }
}
