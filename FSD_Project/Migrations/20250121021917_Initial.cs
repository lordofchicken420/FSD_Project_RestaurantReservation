using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FSD_Project.Migrations
{
    /// <inheritdoc />
    public partial class Intial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Branch",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contactNumber = table.Column<int>(type: "int", nullable: false),
                    NumOfTables = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    contactNumber = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staff_Branch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Table",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Table_Branch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Pax = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TableID = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: true),
                    CustomerId1 = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservation_Branch_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branch",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reservation_Customer_CustomerId1",
                        column: x => x.CustomerId1,
                        principalTable: "Customer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reservation_Table_TableID",
                        column: x => x.TableID,
                        principalTable: "Table",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
<<<<<<<< HEAD:FSD_Project/Migrations/20250125054220_Intial.cs
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "1d11f920-c658-4b76-8a5b-e8d2297aab44", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEBkgKWh03leQ33y8bXWf777w3JqbUgshnPvikM9MTKxYfzu6uryFc2KfeEGbnWiD7w==", null, false, "217307e6-f56e-4d93-b0ba-c678229e3d7b", false, "admin@localhost.com" });
========
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "4c2866d0-938e-4438-a3ad-20b047382cd5", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAECC1CBK/1o37DSX6GzqNwziKFfHoU/YdS3M83qiak1DlBgLnlLCFBS4Y/AQPZFK09A==", null, false, "3986992f-9852-41f2-89d0-ccee6b174b49", false, "admin@localhost.com" });
>>>>>>>> b01428e9aa1814c08f51b6099a2802287f85b7d8:FSD_Project/Migrations/20250121021917_Initial.cs

            migrationBuilder.InsertData(
                table: "Branch",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Location", "Name", "NumOfTables", "UpdatedBy", "contactNumber" },
                values: new object[,]
                {
<<<<<<<< HEAD:FSD_Project/Migrations/20250125054220_Intial.cs
                    { 1, "System", new DateTime(2025, 1, 25, 13, 42, 18, 692, DateTimeKind.Local).AddTicks(9525), new DateTime(2025, 1, 25, 13, 42, 18, 692, DateTimeKind.Local).AddTicks(9537), "Woodlands", "Branch 1", 15, "System", 61234567 },
                    { 2, "System", new DateTime(2025, 1, 25, 13, 42, 18, 692, DateTimeKind.Local).AddTicks(9542), new DateTime(2025, 1, 25, 13, 42, 18, 692, DateTimeKind.Local).AddTicks(9544), "Punggol", "Branch 2", 15, "System", 61234566 }
========
                    { 1, "System", new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2011), new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2023), "Woodlands", "Branch 1", 15, "System", 61234567 },
                    { 2, "System", new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2027), new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2028), "Punggol", "Branch 2", 15, "System", 61234566 }
>>>>>>>> b01428e9aa1814c08f51b6099a2802287f85b7d8:FSD_Project/Migrations/20250121021917_Initial.cs
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Email", "Gender", "Name", "UpdatedBy" },
                values: new object[,]
                {
<<<<<<<< HEAD:FSD_Project/Migrations/20250125054220_Intial.cs
                    { 1, "System", new DateTime(2025, 1, 25, 13, 42, 18, 692, DateTimeKind.Local).AddTicks(9930), new DateTime(2025, 1, 25, 13, 42, 18, 692, DateTimeKind.Local).AddTicks(9931), "David@hotmail.com", "Male", "David Lee", "System" },
                    { 2, "System", new DateTime(2025, 1, 25, 13, 42, 18, 692, DateTimeKind.Local).AddTicks(9935), new DateTime(2025, 1, 25, 13, 42, 18, 692, DateTimeKind.Local).AddTicks(9936), "johnmatthew@gmail.com", "Male", "John Matthew", "System" }
========
                    { 1, "System", new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2263), new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2263), "Male", "David Lee", "System", 91234567 },
                    { 2, "System", new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2267), new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2267), "Male", "John Matthew", "System", 91234566 }
>>>>>>>> b01428e9aa1814c08f51b6099a2802287f85b7d8:FSD_Project/Migrations/20250121021917_Initial.cs
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "Id", "BranchId", "CreatedBy", "DateCreated", "DateUpdated", "Gender", "Name", "UpdatedBy", "contactNumber" },
                values: new object[,]
                {
<<<<<<<< HEAD:FSD_Project/Migrations/20250125054220_Intial.cs
                    { 1, 1, "System", new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(518), new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(519), "Male", "Gordon Sim", "System", 97581578 },
                    { 2, 1, "System", new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(523), new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(524), "Female", "En Xuan", "System", 98886482 }
========
                    { 1, 1, "System", new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2532), new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2533), "Male", "Gordon Sim", "System", 97581578 },
                    { 2, 1, "System", new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2537), new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2537), "Female", "En Xuan", "System", 98886482 }
>>>>>>>> b01428e9aa1814c08f51b6099a2802287f85b7d8:FSD_Project/Migrations/20250121021917_Initial.cs
                });

            migrationBuilder.InsertData(
                table: "Table",
                columns: new[] { "Id", "BranchId", "Capacity", "CreatedBy", "DateCreated", "DateUpdated", "Status", "UpdatedBy" },
                values: new object[,]
                {
<<<<<<<< HEAD:FSD_Project/Migrations/20250125054220_Intial.cs
                    { 1, 1, 10, "System", new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(727), new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(728), true, "System" },
                    { 2, 1, 10, "System", new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(732), new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(733), true, "System" },
                    { 3, 1, 10, "System", new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(737), new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(738), true, "System" },
                    { 4, 1, 10, "System", new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(741), new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(742), true, "System" },
                    { 5, 1, 10, "System", new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(746), new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(747), true, "System" },
                    { 6, 1, 10, "System", new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(750), new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(752), true, "System" },
                    { 7, 1, 10, "System", new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(755), new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(756), true, "System" },
                    { 8, 1, 10, "System", new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(760), new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(761), true, "System" },
                    { 9, 1, 10, "System", new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(765), new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(766), true, "System" },
                    { 10, 1, 10, "System", new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(769), new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(770), true, "System" }
========
                    { 1, 1, 10, "System", new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2643), new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2644), true, "System" },
                    { 2, 1, 10, "System", new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2647), new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2648), true, "System" },
                    { 3, 1, 10, "System", new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2650), new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2651), true, "System" },
                    { 4, 1, 10, "System", new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2653), new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2654), true, "System" },
                    { 5, 1, 10, "System", new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2656), new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2657), true, "System" },
                    { 6, 1, 10, "System", new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2659), new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2660), true, "System" },
                    { 7, 1, 10, "System", new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2663), new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2664), true, "System" },
                    { 8, 1, 10, "System", new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2667), new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2668), true, "System" },
                    { 9, 1, 10, "System", new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2671), new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2672), true, "System" },
                    { 10, 1, 10, "System", new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2674), new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2675), true, "System" }
>>>>>>>> b01428e9aa1814c08f51b6099a2802287f85b7d8:FSD_Project/Migrations/20250121021917_Initial.cs
                });

            migrationBuilder.InsertData(
                table: "Reservation",
                columns: new[] { "Id", "BranchId", "CreatedBy", "CustomerId", "CustomerId1", "DateCreated", "DateUpdated", "Pax", "ReservedDateTime", "TableID", "UpdatedBy" },
                values: new object[,]
                {
<<<<<<<< HEAD:FSD_Project/Migrations/20250125054220_Intial.cs
                    { 1, null, "System", "1", null, new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(137), new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(139), 3, new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(134), 1, "System" },
                    { 2, null, "System", "2", null, new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(143), new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(145), 2, new DateTime(2025, 1, 25, 13, 42, 18, 693, DateTimeKind.Local).AddTicks(141), 2, "System" }
========
                    { 1, null, "System", "1", null, new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2381), new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2382), 3, new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2379), 1, "System" },
                    { 2, null, "System", "2", null, new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2386), new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2386), 2, new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2384), 2, "System" }
>>>>>>>> b01428e9aa1814c08f51b6099a2802287f85b7d8:FSD_Project/Migrations/20250121021917_Initial.cs
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_BranchId",
                table: "Reservation",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_CustomerId1",
                table: "Reservation",
                column: "CustomerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_TableID",
                table: "Reservation",
                column: "TableID");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_BranchId",
                table: "Staff",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Table_BranchId",
                table: "Table",
                column: "BranchId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Table");

            migrationBuilder.DropTable(
                name: "Branch");
        }
    }
}
