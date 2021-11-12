﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Opgave2;

namespace Opgave2.Migrations
{
    [DbContext(typeof(MuncipalityDbContext))]
    partial class MuncipalityDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("Opgave2.Addresses", b =>
                {
                    b.Property<int>("addressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("number")
                        .HasColumnType("INTEGER");

                    b.Property<int>("postalCode")
                        .HasMaxLength(4)
                        .HasColumnType("INTEGER");

                    b.Property<string>("street")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("addressId");

                    b.ToTable("addresses");
                });

            modelBuilder.Entity("Opgave2.Locations", b =>
                {
                    b.Property<int>("locationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("addressId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("description")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<int?>("municipalityzipCode")
                        .HasColumnType("INTEGER");

                    b.Property<int>("zipCode")
                        .HasColumnType("INTEGER");

                    b.HasKey("locationId");

                    b.HasIndex("addressId");

                    b.HasIndex("municipalityzipCode");

                    b.ToTable("locations");
                });

            modelBuilder.Entity("Opgave2.Memberships", b =>
                {
                    b.Property<int>("membershipId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("cpr")
                        .HasColumnType("TEXT");

                    b.Property<string>("cvr")
                        .HasColumnType("TEXT");

                    b.Property<bool>("isChairman")
                        .HasColumnType("INTEGER");

                    b.Property<string>("personcpr")
                        .HasColumnType("TEXT");

                    b.Property<string>("societycvr")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("membershipId");

                    b.HasIndex("personcpr");

                    b.HasIndex("societycvr");

                    b.ToTable("memberships");
                });

            modelBuilder.Entity("Opgave2.Municipalities", b =>
                {
                    b.Property<int>("zipCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("zipCode");

                    b.ToTable("municipalities");
                });

            modelBuilder.Entity("Opgave2.Persons", b =>
                {
                    b.Property<string>("cpr")
                        .HasMaxLength(11)
                        .HasColumnType("TEXT");

                    b.Property<int>("addressId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("cpr");

                    b.HasIndex("addressId");

                    b.ToTable("persons");
                });

            modelBuilder.Entity("Opgave2.Properties", b =>
                {
                    b.Property<int>("propertyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("description")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int>("locationId")
                        .HasColumnType("INTEGER");

                    b.HasKey("propertyId");

                    b.HasIndex("locationId");

                    b.ToTable("properties");
                });

            modelBuilder.Entity("Opgave2.RoomBookings", b =>
                {
                    b.Property<int>("roomBookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("cvr")
                        .HasColumnType("TEXT");

                    b.Property<string>("description")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("societiecvr")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("timespanId")
                        .HasColumnType("INTEGER");

                    b.HasKey("roomBookingId");

                    b.HasIndex("societiecvr");

                    b.HasIndex("timespanId");

                    b.ToTable("roomBookings");
                });

            modelBuilder.Entity("Opgave2.Rooms", b =>
                {
                    b.Property<int>("roomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("capacity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("locationId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("roomId");

                    b.HasIndex("locationId");

                    b.ToTable("rooms");
                });

            modelBuilder.Entity("Opgave2.Societies", b =>
                {
                    b.Property<string>("cvr")
                        .HasMaxLength(8)
                        .HasColumnType("TEXT");

                    b.Property<string>("activity")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int>("addressId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("municipalityzipCode")
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int>("zipCode")
                        .HasColumnType("INTEGER");

                    b.HasKey("cvr");

                    b.HasIndex("addressId");

                    b.HasIndex("municipalityzipCode");

                    b.ToTable("societies");
                });

            modelBuilder.Entity("Opgave2.Timespans", b =>
                {
                    b.Property<int>("timespanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("closingTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("openingTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("roomId")
                        .HasColumnType("INTEGER");

                    b.HasKey("timespanId");

                    b.HasIndex("roomId");

                    b.ToTable("timespans");
                });

            modelBuilder.Entity("PropertiesRoomBookings", b =>
                {
                    b.Property<int>("propertiespropertyId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("roomBookingsroomBookingId")
                        .HasColumnType("INTEGER");

                    b.HasKey("propertiespropertyId", "roomBookingsroomBookingId");

                    b.HasIndex("roomBookingsroomBookingId");

                    b.ToTable("PropertiesRoomBookings");
                });

            modelBuilder.Entity("Opgave2.Locations", b =>
                {
                    b.HasOne("Opgave2.Addresses", "address")
                        .WithMany()
                        .HasForeignKey("addressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Opgave2.Municipalities", "municipality")
                        .WithMany("locations")
                        .HasForeignKey("municipalityzipCode");

                    b.Navigation("address");

                    b.Navigation("municipality");
                });

            modelBuilder.Entity("Opgave2.Memberships", b =>
                {
                    b.HasOne("Opgave2.Persons", "person")
                        .WithMany()
                        .HasForeignKey("personcpr");

                    b.HasOne("Opgave2.Societies", "society")
                        .WithMany("memberships")
                        .HasForeignKey("societycvr")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("person");

                    b.Navigation("society");
                });

            modelBuilder.Entity("Opgave2.Persons", b =>
                {
                    b.HasOne("Opgave2.Addresses", "address")
                        .WithMany()
                        .HasForeignKey("addressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("address");
                });

            modelBuilder.Entity("Opgave2.Properties", b =>
                {
                    b.HasOne("Opgave2.Locations", "location")
                        .WithMany("properties")
                        .HasForeignKey("locationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("location");
                });

            modelBuilder.Entity("Opgave2.RoomBookings", b =>
                {
                    b.HasOne("Opgave2.Societies", "societie")
                        .WithMany("roomBookings")
                        .HasForeignKey("societiecvr")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Opgave2.Timespans", "timespan")
                        .WithMany()
                        .HasForeignKey("timespanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("societie");

                    b.Navigation("timespan");
                });

            modelBuilder.Entity("Opgave2.Rooms", b =>
                {
                    b.HasOne("Opgave2.Locations", "location")
                        .WithMany("rooms")
                        .HasForeignKey("locationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("location");
                });

            modelBuilder.Entity("Opgave2.Societies", b =>
                {
                    b.HasOne("Opgave2.Addresses", "address")
                        .WithMany()
                        .HasForeignKey("addressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Opgave2.Municipalities", "municipality")
                        .WithMany("societies")
                        .HasForeignKey("municipalityzipCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("address");

                    b.Navigation("municipality");
                });

            modelBuilder.Entity("Opgave2.Timespans", b =>
                {
                    b.HasOne("Opgave2.Rooms", "room")
                        .WithMany("timespans")
                        .HasForeignKey("roomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("room");
                });

            modelBuilder.Entity("PropertiesRoomBookings", b =>
                {
                    b.HasOne("Opgave2.Properties", null)
                        .WithMany()
                        .HasForeignKey("propertiespropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Opgave2.RoomBookings", null)
                        .WithMany()
                        .HasForeignKey("roomBookingsroomBookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Opgave2.Locations", b =>
                {
                    b.Navigation("properties");

                    b.Navigation("rooms");
                });

            modelBuilder.Entity("Opgave2.Municipalities", b =>
                {
                    b.Navigation("locations");

                    b.Navigation("societies");
                });

            modelBuilder.Entity("Opgave2.Rooms", b =>
                {
                    b.Navigation("timespans");
                });

            modelBuilder.Entity("Opgave2.Societies", b =>
                {
                    b.Navigation("memberships");

                    b.Navigation("roomBookings");
                });
#pragma warning restore 612, 618
        }
    }
}
