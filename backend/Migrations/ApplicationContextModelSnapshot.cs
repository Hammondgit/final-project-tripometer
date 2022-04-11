﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TripometerAPI;

namespace TripometerAPI.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TripometerAPI.Models.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Owners");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = " Joe",
                            FullName = "Joe Smith",
                            LastName = "Smith"
                        });
                });

            modelBuilder.Entity("TripometerAPI.Models.Receipt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdditionalCosts")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("GasStation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PricePerGallon")
                        .HasColumnType("int");

                    b.Property<int>("TotalCost")
                        .HasColumnType("int");

                    b.Property<int>("TripId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TripId");

                    b.ToTable("Receipts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdditionalCosts = 1200,
                            Date = new DateTime(2022, 4, 8, 16, 35, 34, 24, DateTimeKind.Local).AddTicks(4560),
                            GasStation = "Cleveland",
                            PricePerGallon = 4,
                            TotalCost = 800,
                            TripId = 1
                        });
                });

            modelBuilder.Entity("TripometerAPI.Models.Trip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Distance")
                        .HasColumnType("int");

                    b.Property<int>("ETA")
                        .HasColumnType("int");

                    b.Property<string>("EndAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstimatedGasCost")
                        .HasColumnType("int");

                    b.Property<int>("EstimatedTotalCost")
                        .HasColumnType("int");

                    b.Property<int>("MileageAfter")
                        .HasColumnType("int");

                    b.Property<int>("MileageBefore")
                        .HasColumnType("int");

                    b.Property<string>("StartAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VehicleId");

                    b.ToTable("Trips");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Distance = 200,
                            ETA = 60,
                            EndAddress = "Columbus",
                            EstimatedGasCost = 5,
                            EstimatedTotalCost = 1000,
                            MileageAfter = 20400,
                            MileageBefore = 20000,
                            StartAddress = "Cleveland",
                            VehicleId = 1
                        });
                });

            modelBuilder.Entity("TripometerAPI.Models.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FuelEfficiency")
                        .HasColumnType("int");

                    b.Property<string>("Make")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<string>("Year")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Vehicles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FuelEfficiency = 25,
                            Make = "Ford",
                            Model = "Mustang",
                            OwnerId = 1,
                            Year = "2020"
                        });
                });

            modelBuilder.Entity("TripometerAPI.Models.Receipt", b =>
                {
                    b.HasOne("TripometerAPI.Models.Trip", "Trip")
                        .WithMany("Receipt")
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trip");
                });

            modelBuilder.Entity("TripometerAPI.Models.Trip", b =>
                {
                    b.HasOne("TripometerAPI.Models.Vehicle", "Vehicle")
                        .WithMany("Trips")
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("TripometerAPI.Models.Vehicle", b =>
                {
                    b.HasOne("TripometerAPI.Models.Owner", "Owner")
                        .WithMany("Vehicles")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("TripometerAPI.Models.Owner", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("TripometerAPI.Models.Trip", b =>
                {
                    b.Navigation("Receipt");
                });

            modelBuilder.Entity("TripometerAPI.Models.Vehicle", b =>
                {
                    b.Navigation("Trips");
                });
#pragma warning restore 612, 618
        }
    }
}
