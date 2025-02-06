using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FSD_Project.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
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
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customer_AspNetUsers_UserId",
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
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNumber = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staff_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Score = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReservationId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReservationId1 = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Reservation_ReservationId1",
                        column: x => x.ReservationId1,
                        principalTable: "Reservation",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Admin", "ADMIN" },
                    { "customer-role-id", null, "Customer", "CUSTOMER" },
                    { "staff-role-id", null, "Staff", "STAFF" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "f90dd219-a97c-46cb-a8a2-4ef66ce84dc0", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEA3qHRzDCQaxnJdGeI2nLNgC4ALaZ0xkmrCwhG9S9tjDY0M2kcHuPx2o+Ix1lKW6eg==", null, false, "40e05916-48c8-47e5-880b-2f5f8d7839e2", false, "admin@localhost.com" },
                    { "customer1-id", 0, "c00a224d-4e0b-469a-8aa0-dcfca82fe112", "customer1@example.com", true, "John", "Doe", false, null, "CUSTOMER1@EXAMPLE.COM", "CUSTOMER1@EXAMPLE.COM", "AQAAAAIAAYagAAAAENAagqf/OKZ9KIg/5P5lgewlgpzWJpNttkGGAPSn9duASdzJPJx3+KPiPqi9WzHeRw==", null, false, "dc95de23-90e5-4ff9-bfb4-081f24e39043", false, "customer1@example.com" },
                    { "staff1-id", 0, "9a5a6e08-dddc-48e1-900e-c20edf85d6d3", "staff1@example.com", true, "Jane", "Smith", false, null, "STAFF1@EXAMPLE.COM", "STAFF1@EXAMPLE.COM", "AQAAAAIAAYagAAAAEP56sDdvwtTPcTsNsq78TrKDCC9FZe761bn8qVRmLnnc+cMWb/ok+9MIp+ZagliyTQ==", null, false, "1df0d158-57cb-4310-9e2b-f9567c454c3e", false, "staff1@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Branch",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Location", "Name", "NumOfTables", "UpdatedBy", "contactNumber" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 2, 6, 19, 0, 36, 583, DateTimeKind.Local).AddTicks(1484), new DateTime(2025, 2, 6, 19, 0, 36, 583, DateTimeKind.Local).AddTicks(1495), "Woodlands", "Branch 1", 15, "System", 61234567 },
                    { 2, "System", new DateTime(2025, 2, 6, 19, 0, 36, 583, DateTimeKind.Local).AddTicks(1498), new DateTime(2025, 2, 6, 19, 0, 36, 583, DateTimeKind.Local).AddTicks(1499), "Punggol", "Branch 2", 15, "System", 61234566 }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Email", "Gender", "Name", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 2, 6, 19, 0, 36, 583, DateTimeKind.Local).AddTicks(1629), new DateTime(2025, 2, 6, 19, 0, 36, 583, DateTimeKind.Local).AddTicks(1629), "David@hotmail.com", "Male", "David Lee", "System", null },
                    { 2, "System", new DateTime(2025, 2, 6, 19, 0, 36, 583, DateTimeKind.Local).AddTicks(1631), new DateTime(2025, 2, 6, 19, 0, 36, 583, DateTimeKind.Local).AddTicks(1632), "johnmatthew@gmail.com", "Male", "John Matthew", "System", null }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "CreatedBy", "DateCreated", "DateUpdated", "ReservationId", "ReservationId1", "Score", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "The Greek Salad was the perfect mix of vegetables, fruits and dressing!", "System", new DateTime(2025, 2, 6, 19, 0, 36, 699, DateTimeKind.Local).AddTicks(431), new DateTime(2025, 2, 6, 19, 0, 36, 699, DateTimeKind.Local).AddTicks(445), "1", null, 5, "System" },
                    { 2, "The Baklava was unlike anything I have ever eaten before", "System", new DateTime(2025, 2, 6, 19, 0, 36, 699, DateTimeKind.Local).AddTicks(447), new DateTime(2025, 2, 6, 19, 0, 36, 699, DateTimeKind.Local).AddTicks(447), "2", null, 5, "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" },
                    { "customer-role-id", "customer1-id" },
                    { "staff-role-id", "staff1-id" }
                });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "Id", "BranchId", "ContactNumber", "CreatedBy", "DateCreated", "DateUpdated", "Email", "Gender", "Name", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 97581578, "System", new DateTime(2025, 2, 6, 19, 0, 36, 583, DateTimeKind.Local).AddTicks(1750), new DateTime(2025, 2, 6, 19, 0, 36, 583, DateTimeKind.Local).AddTicks(1751), "Gordon@hotmail.com", "Male", "Gordon Sim", "System", null },
                    { 2, 1, 98886482, "System", new DateTime(2025, 2, 6, 19, 0, 36, 583, DateTimeKind.Local).AddTicks(1753), new DateTime(2025, 2, 6, 19, 0, 36, 583, DateTimeKind.Local).AddTicks(1753), "EnXuan@hotmail.com", "Female", "En Xuan", "System", null }
                });

            migrationBuilder.InsertData(
                table: "Table",
                columns: new[] { "Id", "BranchId", "Capacity", "CreatedBy", "DateCreated", "DateUpdated", "Status", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, 10, "System", new DateTime(2025, 2, 6, 19, 0, 36, 583, DateTimeKind.Local).AddTicks(1809), new DateTime(2025, 2, 6, 19, 0, 36, 583, DateTimeKind.Local).AddTicks(1810), true, "System" },
                    { 2, 1, 10, "System", new DateTime(2025, 2, 6, 19, 0, 36, 583, DateTimeKind.Local).AddTicks(1812), new DateTime(2025, 2, 6, 19, 0, 36, 583, DateTimeKind.Local).AddTicks(1812), true, "System" },
                    { 3, 1, 10, "System", new DateTime(2025, 2, 6, 19, 0, 36, 583, DateTimeKind.Local).AddTicks(1813), new DateTime(2025, 2, 6, 19, 0, 36, 583, DateTimeKind.Local).AddTicks(1814), true, "System" },
                    { 4, 1, 10, "System", new DateTime(2025, 2, 6, 19, 0, 36, 583, DateTimeKind.Local).AddTicks(1815), new DateTime(2025, 2, 6, 19, 0, 36, 583, DateTimeKind.Local).AddTicks(1815), true, "System" },
                    { 5, 1, 10, "System", new DateTime(2025, 2, 6, 19, 0, 36, 583, DateTimeKind.Local).AddTicks(1817), new DateTime(2025, 2, 6, 19, 0, 36, 583, DateTimeKind.Local).AddTicks(1817), true, "System" },
                    { 6, 2, 10, "System", new DateTime(2025, 2, 6, 19, 0, 36, 583, DateTimeKind.Local).AddTicks(1818), new DateTime(2025, 2, 6, 19, 0, 36, 583, DateTimeKind.Local).AddTicks(1819), true, "System" },
                    { 7, 2, 10, "System", new DateTime(2025, 2, 6, 19, 0, 36, 583, DateTimeKind.Local).AddTicks(1820), new DateTime(2025, 2, 6, 19, 0, 36, 583, DateTimeKind.Local).AddTicks(1820), true, "System" },
                    { 8, 2, 10, "System", new DateTime(2025, 2, 6, 19, 0, 36, 583, DateTimeKind.Local).AddTicks(1822), new DateTime(2025, 2, 6, 19, 0, 36, 583, DateTimeKind.Local).AddTicks(1822), true, "System" },
                    { 9, 2, 10, "System", new DateTime(2025, 2, 6, 19, 0, 36, 583, DateTimeKind.Local).AddTicks(1823), new DateTime(2025, 2, 6, 19, 0, 36, 583, DateTimeKind.Local).AddTicks(1824), true, "System" },
                    { 10, 2, 10, "System", new DateTime(2025, 2, 6, 19, 0, 36, 583, DateTimeKind.Local).AddTicks(1825), new DateTime(2025, 2, 6, 19, 0, 36, 583, DateTimeKind.Local).AddTicks(1825), true, "System" }
                });

            migrationBuilder.InsertData(
                table: "Reservation",
                columns: new[] { "Id", "BranchId", "CreatedBy", "CustomerId", "CustomerId1", "DateCreated", "DateUpdated", "ReservedDateTime", "TableID", "Time", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, "System", "1", null, new DateTime(2025, 2, 6, 19, 0, 36, 583, DateTimeKind.Local).AddTicks(1691), new DateTime(2025, 2, 6, 19, 0, 36, 583, DateTimeKind.Local).AddTicks(1692), new DateTime(2025, 2, 6, 19, 0, 36, 583, DateTimeKind.Local).AddTicks(1690), 1, "12:30", "System" },
                    { 2, null, "System", "2", null, new DateTime(2025, 2, 6, 19, 0, 36, 583, DateTimeKind.Local).AddTicks(1694), new DateTime(2025, 2, 6, 19, 0, 36, 583, DateTimeKind.Local).AddTicks(1694), new DateTime(2025, 2, 6, 19, 0, 36, 583, DateTimeKind.Local).AddTicks(1693), 2, "12:30", "System" }
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
                name: "IX_Customer_UserId",
                table: "Customer",
                column: "UserId");

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
                name: "IX_Reviews_ReservationId1",
                table: "Reviews",
                column: "ReservationId1");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_BranchId",
                table: "Staff",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_UserId",
                table: "Staff",
                column: "UserId");

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
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Table");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Branch");
        }
    }
}
