﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TripometerAPI.Migrations
{
    public partial class InIt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Owners_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    FuelEfficiency = table.Column<float>(type: "real", nullable: false),
                    OwnerId = table.Column<int>(type: "int", nullable: true),
                    FuelTank = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicles_Owners_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Owners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmbarkDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DisembarkDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MileageBefore = table.Column<int>(type: "int", nullable: false),
                    ArrivalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Distance = table.Column<double>(type: "float", nullable: false),
                    EstimatedGasCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EstimatedFuelUsage = table.Column<double>(type: "float", nullable: false),
                    VehicleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trips_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Receipts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PricePerGallon = table.Column<int>(type: "int", nullable: false),
                    TotalCost = table.Column<int>(type: "int", nullable: false),
                    AdditionalCosts = table.Column<int>(type: "int", nullable: false),
                    GasStation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TripId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receipts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Receipts_Trips_TripId",
                        column: x => x.TripId,
                        principalTable: "Trips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "Username" },
                values: new object[,]
                {
<<<<<<<< HEAD:backend/Migrations/20220414142122_InIt.cs
                    { 1, "$2a$11$qMkpHUKPBshTg.btc.bjUe7qOVmAPngFn/1k9oWc4b7pDZcXbV8x6", "TestUser1" },
                    { 2, "$2a$11$EEc7ZTTsATW0AAtLS.GB2eJW1cbFbEEZBRr1bu4AEtTxLBMnVgTfa", "TestUser2" },
                    { 3, "$2a$11$ZsI4FdGTvUJLclZPMjIqbelTwFtCiWLqLZGdhiKlmNT1FEcbLHF76", "TestUser3" },
                    { 4, "$2a$11$gqITJWULyajZ6oQjjSEOqe/zY31S6xyak53sdDCyocb0kOKXa31EC", "TestUser4" },
                    { 5, "$2a$11$PnPVQhMvsx35FjKtC4yhxOzL2JfTBCZ1d9PL9OeV79zQ3f2idj/hm", "TestUser5" },
                    { 6, "$2a$11$.yTWrUVepqInjbWFSSKVWuydIdktHkpdKb4x5gtQc6ZSm6wd/W1Ce", "TestUser6" }
========
                    { 1, "$2a$11$tG2RdfO5WFiYY8JCbBf6feOrDiZftKZmIOpzHKGNcMrJnjEw0IWwu", "TestUser1" },
                    { 2, "$2a$11$/nVJe/WS/OGxB/KHpjWE0uWzUf1E7AF8bVgtJLedMLS8BiK3M1LRW", "TestUser2" },
                    { 3, "$2a$11$zQBmXi0546vy9VsoLMpsBOZXd868P2Yg0rKkG76ybBWn5y7vUzxI6", "TestUser3" },
                    { 4, "$2a$11$rejtE2M/.tmtltZMGYPir.KpTxQ.BMI.uuOe6IX0o2kGCw.dbris6", "TestUser4" },
                    { 5, "$2a$11$Rup6CECUzoFYZA67zXy4Lem6YLwcwsOuE10gOh2TL7FgLD5LAYdqK", "TestUser5" },
                    { 6, "$2a$11$tSwXWJRHWJGpkrMEdenU8Oobz8Pw/sX7v6zPD4MaWnB96hABQEw4i", "TestUser6" }
>>>>>>>> 8a2f1a85cabb108cc5d3c9ad046ae4e4744217cd:backend/Migrations/20220414150224_init.cs
                });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "FirstName", "LastName", "UserId" },
                values: new object[,]
                {
                    { 1, "Denzale", "Mclntyre", 1 },
                    { 2, "Jessica", "Wang", 2 },
                    { 3, "Darius", "Hammond", 3 },
                    { 4, "Rimma", "Girsheva", 4 },
                    { 5, "Qadriyyah", "Johnson", 5 },
                    { 6, "Brad", "Weir", 6 }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "FuelEfficiency", "FuelTank", "Make", "Model", "OwnerId", "Year" },
                values: new object[,]
                {
                    { 1, 21f, 16f, "Ford", "Mustang", 1, 2021 },
                    { 2, 36f, 59f, "BMW", "3 Series", 1, 2020 },
                    { 3, 24f, 17.6f, "Carrear 4S Cabriolet", "Porsche", 2, 2020 },
                    { 4, 20f, 24f, "GT", "Bentley", 2, 2020 },
                    { 5, 21f, 16f, "BMW", "xDrive28i", 3, 2017 },
                    { 6, 36f, 59f, "BMW", "3 Series", 3, 2020 },
                    { 7, 21f, 16f, "Buick", "Encore", 4, 2019 },
                    { 8, 36f, 59f, "Toyota", "Crown", 4, 2019 },
                    { 9, 47f, 19f, "BMW", "X5", 5, 2019 },
                    { 10, 30f, 14.5f, "Volkswagen", "EOS", 5, 2016 },
                    { 11, 28f, 12.4f, "Honda", "Civic Type-R", 6, 2022 }
                });

<<<<<<<< HEAD:backend/Migrations/20220414142122_InIt.cs
            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "DisembarkDate", "Distance", "ETA", "EmbarkDate", "EndAddress", "EstimatedGasCost", "EstimatedTotalCost", "MileageAfter", "MileageBefore", "StartAddress", "VehicleId" },
                values: new object[,]
                {
                    { 1, null, 200, 60, new DateTime(2022, 3, 31, 7, 21, 21, 539, DateTimeKind.Local).AddTicks(6243), "Columbus", 5, 1000, 20400, 20000, "Cleveland", 1 },
                    { 2, null, 200, 60, new DateTime(2022, 4, 8, 7, 21, 21, 542, DateTimeKind.Local).AddTicks(2780), "Miami", 5, 1000, 20400, 20000, "Shaker", 1 },
                    { 3, null, 200, 60, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Columbus", 5, 1000, 20400, 20000, "Chicago", 1 },
                    { 5, null, 200, 60, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cincinnati", 5, 1000, 20400, 20000, "Cleveland", 1 },
                    { 6, null, 200, 60, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cincinnati", 5, 1000, 20400, 20000, "Cleveland", 1 },
                    { 7, null, 200, 60, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Columbus", 5, 1000, 20400, 20000, "Chicago", 1 },
                    { 4, null, 200, 60, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "NYC", 5, 1000, 20400, 20000, "Kent", 2 },
                    { 8, null, 200, 60, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miami", 5, 1000, 20400, 20000, "Shaker", 2 }
                });

            migrationBuilder.InsertData(
                table: "Receipts",
                columns: new[] { "Id", "AdditionalCosts", "Date", "GasStation", "PricePerGallon", "TotalCost", "TripId" },
                values: new object[] { 2, 1200, new DateTime(2022, 4, 14, 7, 21, 21, 542, DateTimeKind.Local).AddTicks(6866), "Shaker", 5, 800, 1 });

            migrationBuilder.InsertData(
                table: "Receipts",
                columns: new[] { "Id", "AdditionalCosts", "Date", "GasStation", "PricePerGallon", "TotalCost", "TripId" },
                values: new object[] { 3, 1200, new DateTime(2022, 4, 14, 7, 21, 21, 542, DateTimeKind.Local).AddTicks(6925), "Shaker", 6, 800, 1 });

            migrationBuilder.InsertData(
                table: "Receipts",
                columns: new[] { "Id", "AdditionalCosts", "Date", "GasStation", "PricePerGallon", "TotalCost", "TripId" },
                values: new object[] { 1, 1200, new DateTime(2022, 4, 14, 7, 21, 21, 542, DateTimeKind.Local).AddTicks(4084), "Cleveland", 4, 800, 2 });

========
>>>>>>>> 8a2f1a85cabb108cc5d3c9ad046ae4e4744217cd:backend/Migrations/20220414150224_init.cs
            migrationBuilder.CreateIndex(
                name: "IX_Owners_UserId",
                table: "Owners",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_TripId",
                table: "Receipts",
                column: "TripId");

            migrationBuilder.CreateIndex(
                name: "IX_Trips_VehicleId",
                table: "Trips",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_OwnerId",
                table: "Vehicles",
                column: "OwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Receipts");

            migrationBuilder.DropTable(
                name: "Trips");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Owners");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
