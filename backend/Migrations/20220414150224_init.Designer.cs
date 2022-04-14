﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TripometerAPI;

namespace TripometerAPI.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220414150224_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Owners");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Denzale",
                            LastName = "Mclntyre",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Jessica",
                            LastName = "Wang",
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Darius",
                            LastName = "Hammond",
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Rimma",
                            LastName = "Girsheva",
                            UserId = 4
                        },
                        new
                        {
                            Id = 5,
                            FirstName = "Qadriyyah",
                            LastName = "Johnson",
                            UserId = 5
                        },
                        new
                        {
                            Id = 6,
                            FirstName = "Brad",
                            LastName = "Weir",
                            UserId = 6
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
                });

            modelBuilder.Entity("TripometerAPI.Models.Trip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ArrivalDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DisembarkDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Distance")
                        .HasColumnType("float");

                    b.Property<DateTime>("EmbarkDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EndAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("EstimatedFuelUsage")
                        .HasColumnType("float");

                    b.Property<decimal>("EstimatedGasCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("MileageBefore")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("StartAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VehicleId");

                    b.ToTable("Trips");
                });

            modelBuilder.Entity("TripometerAPI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PasswordHash = "$2a$11$tG2RdfO5WFiYY8JCbBf6feOrDiZftKZmIOpzHKGNcMrJnjEw0IWwu",
                            Username = "TestUser1"
                        },
                        new
                        {
                            Id = 2,
                            PasswordHash = "$2a$11$/nVJe/WS/OGxB/KHpjWE0uWzUf1E7AF8bVgtJLedMLS8BiK3M1LRW",
                            Username = "TestUser2"
                        },
                        new
                        {
                            Id = 3,
                            PasswordHash = "$2a$11$zQBmXi0546vy9VsoLMpsBOZXd868P2Yg0rKkG76ybBWn5y7vUzxI6",
                            Username = "TestUser3"
                        },
                        new
                        {
                            Id = 4,
                            PasswordHash = "$2a$11$rejtE2M/.tmtltZMGYPir.KpTxQ.BMI.uuOe6IX0o2kGCw.dbris6",
                            Username = "TestUser4"
                        },
                        new
                        {
                            Id = 5,
                            PasswordHash = "$2a$11$Rup6CECUzoFYZA67zXy4Lem6YLwcwsOuE10gOh2TL7FgLD5LAYdqK",
                            Username = "TestUser5"
                        },
                        new
                        {
                            Id = 6,
                            PasswordHash = "$2a$11$tSwXWJRHWJGpkrMEdenU8Oobz8Pw/sX7v6zPD4MaWnB96hABQEw4i",
                            Username = "TestUser6"
                        });
                });

            modelBuilder.Entity("TripometerAPI.Models.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("FuelEfficiency")
                        .HasColumnType("real");

                    b.Property<float>("FuelTank")
                        .HasColumnType("real");

                    b.Property<string>("Make")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OwnerId")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Vehicles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FuelEfficiency = 21f,
                            FuelTank = 16f,
                            Make = "Ford",
                            Model = "Mustang",
                            OwnerId = 1,
                            Year = 2021
                        },
                        new
                        {
                            Id = 2,
                            FuelEfficiency = 36f,
                            FuelTank = 59f,
                            Make = "BMW",
                            Model = "3 Series",
                            OwnerId = 1,
                            Year = 2020
                        },
                        new
                        {
                            Id = 3,
                            FuelEfficiency = 24f,
                            FuelTank = 17.6f,
                            Make = "Carrear 4S Cabriolet",
                            Model = "Porsche",
                            OwnerId = 2,
                            Year = 2020
                        },
                        new
                        {
                            Id = 4,
                            FuelEfficiency = 20f,
                            FuelTank = 24f,
                            Make = "GT",
                            Model = "Bentley",
                            OwnerId = 2,
                            Year = 2020
                        },
                        new
                        {
                            Id = 5,
                            FuelEfficiency = 21f,
                            FuelTank = 16f,
                            Make = "BMW",
                            Model = "xDrive28i",
                            OwnerId = 3,
                            Year = 2017
                        },
                        new
                        {
                            Id = 6,
                            FuelEfficiency = 36f,
                            FuelTank = 59f,
                            Make = "BMW",
                            Model = "3 Series",
                            OwnerId = 3,
                            Year = 2020
                        },
                        new
                        {
                            Id = 7,
                            FuelEfficiency = 21f,
                            FuelTank = 16f,
                            Make = "Buick",
                            Model = "Encore",
                            OwnerId = 4,
                            Year = 2019
                        },
                        new
                        {
                            Id = 8,
                            FuelEfficiency = 36f,
                            FuelTank = 59f,
                            Make = "Toyota",
                            Model = "Crown",
                            OwnerId = 4,
                            Year = 2019
                        },
                        new
                        {
                            Id = 9,
                            FuelEfficiency = 47f,
                            FuelTank = 19f,
                            Make = "BMW",
                            Model = "X5",
                            OwnerId = 5,
                            Year = 2019
                        },
                        new
                        {
                            Id = 10,
                            FuelEfficiency = 30f,
                            FuelTank = 14.5f,
                            Make = "Volkswagen",
                            Model = "EOS",
                            OwnerId = 5,
                            Year = 2016
                        },
                        new
                        {
                            Id = 11,
                            FuelEfficiency = 28f,
                            FuelTank = 12.4f,
                            Make = "Honda",
                            Model = "Civic Type-R",
                            OwnerId = 6,
                            Year = 2022
                        });
                });

            modelBuilder.Entity("TripometerAPI.Models.Owner", b =>
                {
                    b.HasOne("TripometerAPI.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TripometerAPI.Models.Receipt", b =>
                {
                    b.HasOne("TripometerAPI.Models.Trip", "Trip")
                        .WithMany("Receipts")
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
                        .HasForeignKey("OwnerId");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("TripometerAPI.Models.Owner", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("TripometerAPI.Models.Trip", b =>
                {
                    b.Navigation("Receipts");
                });

            modelBuilder.Entity("TripometerAPI.Models.Vehicle", b =>
                {
                    b.Navigation("Trips");
                });
#pragma warning restore 612, 618
        }
    }
}