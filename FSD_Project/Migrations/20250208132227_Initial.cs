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
                    { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "2b9696f0-eebf-492e-b901-e850c72a0c34", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEK8Q7QcZdTvw7i90LwWaIc4vbQqpX5JTo/DMTihSvD33JE1NgxZvj6JUzSB5abdl0g==", null, false, "3780e280-b21c-43c9-92bc-a45f4629ba81", false, "admin@localhost.com" },
                    { "customer1-id", 0, "bc5d253b-01f0-4c73-8cc2-770668f788ee", "customer1@example.com", true, "John", "Doe", false, null, "CUSTOMER1@EXAMPLE.COM", "CUSTOMER1@EXAMPLE.COM", "AQAAAAIAAYagAAAAED6mjUuwYplV0Tg9HxLxqswn/ZlM1nFrwWDRl6YAPRg56mwRLqSj2jQt5iflMBy7HA==", null, false, "a03c0cf1-3ace-4351-b0d7-6f5ca535fb8a", false, "customer1@example.com" },
                    { "staff1-id", 0, "de908a92-7a81-4499-b708-004dabfae37f", "staff1@example.com", true, "Jane", "Smith", false, null, "STAFF1@EXAMPLE.COM", "STAFF1@EXAMPLE.COM", "AQAAAAIAAYagAAAAENiqPOEWjC7B+EvVFtEj/LphDeIHJscMBPvOir8YzIxbj1zfOkXPUsLG8/lldBW28w==", null, false, "4d0f30df-d8c7-4828-93fd-3188dacf610b", false, "staff1@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Branch",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Location", "Name", "NumOfTables", "UpdatedBy", "contactNumber" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 2, 8, 21, 22, 27, 266, DateTimeKind.Local).AddTicks(695), new DateTime(2025, 2, 8, 21, 22, 27, 266, DateTimeKind.Local).AddTicks(704), "Woodlands", "Branch 1", 15, "System", 61234567 },
                    { 2, "System", new DateTime(2025, 2, 8, 21, 22, 27, 266, DateTimeKind.Local).AddTicks(707), new DateTime(2025, 2, 8, 21, 22, 27, 266, DateTimeKind.Local).AddTicks(707), "Punggol", "Branch 2", 15, "System", 61234566 }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Email", "Gender", "Name", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 2, 8, 21, 22, 27, 266, DateTimeKind.Local).AddTicks(867), new DateTime(2025, 2, 8, 21, 22, 27, 266, DateTimeKind.Local).AddTicks(868), "David@hotmail.com", "Male", "David Lee", "System", null },
                    { 2, "System", new DateTime(2025, 2, 8, 21, 22, 27, 266, DateTimeKind.Local).AddTicks(870), new DateTime(2025, 2, 8, 21, 22, 27, 266, DateTimeKind.Local).AddTicks(870), "johnmatthew@gmail.com", "Male", "John Matthew", "System", null }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "CreatedBy", "DateCreated", "DateUpdated", "ReservationId", "ReservationId1", "Score", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "The Greek Salad was the perfect mix of vegetables, fruits and dressing!", "System", new DateTime(2025, 2, 8, 21, 22, 27, 383, DateTimeKind.Local).AddTicks(5006), new DateTime(2025, 2, 8, 21, 22, 27, 383, DateTimeKind.Local).AddTicks(5025), "1", null, 5, "System" },
                    { 2, "The Baklava was unlike anything I have ever eaten before", "System", new DateTime(2025, 2, 8, 21, 22, 27, 383, DateTimeKind.Local).AddTicks(5027), new DateTime(2025, 2, 8, 21, 22, 27, 383, DateTimeKind.Local).AddTicks(5027), "2", null, 5, "System" }
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
                    { 1, 1, 97581578, "System", new DateTime(2025, 2, 8, 21, 22, 27, 266, DateTimeKind.Local).AddTicks(997), new DateTime(2025, 2, 8, 21, 22, 27, 266, DateTimeKind.Local).AddTicks(998), "Gordon@hotmail.com", "Male", "Gordon Sim", "System", null },
                    { 2, 1, 98886482, "System", new DateTime(2025, 2, 8, 21, 22, 27, 266, DateTimeKind.Local).AddTicks(999), new DateTime(2025, 2, 8, 21, 22, 27, 266, DateTimeKind.Local).AddTicks(1000), "EnXuan@hotmail.com", "Female", "En Xuan", "System", null }
                });

            migrationBuilder.InsertData(
                table: "Table",
                columns: new[] { "Id", "BranchId", "Capacity", "CreatedBy", "DateCreated", "DateUpdated", "Status", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, 10, "System", new DateTime(2025, 2, 8, 21, 22, 27, 266, DateTimeKind.Local).AddTicks(1065), new DateTime(2025, 2, 8, 21, 22, 27, 266, DateTimeKind.Local).AddTicks(1065), true, "System" },
                    { 2, 1, 10, "System", new DateTime(2025, 2, 8, 21, 22, 27, 266, DateTimeKind.Local).AddTicks(1068), new DateTime(2025, 2, 8, 21, 22, 27, 266, DateTimeKind.Local).AddTicks(1068), true, "System" },
                    { 3, 1, 10, "System", new DateTime(2025, 2, 8, 21, 22, 27, 266, DateTimeKind.Local).AddTicks(1069), new DateTime(2025, 2, 8, 21, 22, 27, 266, DateTimeKind.Local).AddTicks(1070), true, "System" },
                    { 4, 1, 10, "System", new DateTime(2025, 2, 8, 21, 22, 27, 266, DateTimeKind.Local).AddTicks(1071), new DateTime(2025, 2, 8, 21, 22, 27, 266, DateTimeKind.Local).AddTicks(1071), true, "System" },
                    { 5, 1, 10, "System", new DateTime(2025, 2, 8, 21, 22, 27, 266, DateTimeKind.Local).AddTicks(1073), new DateTime(2025, 2, 8, 21, 22, 27, 266, DateTimeKind.Local).AddTicks(1073), true, "System" },
                    { 6, 2, 10, "System", new DateTime(2025, 2, 8, 21, 22, 27, 266, DateTimeKind.Local).AddTicks(1074), new DateTime(2025, 2, 8, 21, 22, 27, 266, DateTimeKind.Local).AddTicks(1075), true, "System" },
                    { 7, 2, 10, "System", new DateTime(2025, 2, 8, 21, 22, 27, 266, DateTimeKind.Local).AddTicks(1076), new DateTime(2025, 2, 8, 21, 22, 27, 266, DateTimeKind.Local).AddTicks(1076), true, "System" },
                    { 8, 2, 10, "System", new DateTime(2025, 2, 8, 21, 22, 27, 266, DateTimeKind.Local).AddTicks(1078), new DateTime(2025, 2, 8, 21, 22, 27, 266, DateTimeKind.Local).AddTicks(1078), true, "System" },
                    { 9, 2, 10, "System", new DateTime(2025, 2, 8, 21, 22, 27, 266, DateTimeKind.Local).AddTicks(1079), new DateTime(2025, 2, 8, 21, 22, 27, 266, DateTimeKind.Local).AddTicks(1080), true, "System" },
                    { 10, 2, 10, "System", new DateTime(2025, 2, 8, 21, 22, 27, 266, DateTimeKind.Local).AddTicks(1081), new DateTime(2025, 2, 8, 21, 22, 27, 266, DateTimeKind.Local).AddTicks(1081), true, "System" }
                });

            migrationBuilder.InsertData(
                table: "Reservation",
                columns: new[] { "Id", "BranchId", "CreatedBy", "CustomerId", "CustomerId1", "DateCreated", "DateUpdated", "ReservedDateTime", "TableID", "Time", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, "System", "1", null, new DateTime(2025, 2, 8, 21, 22, 27, 266, DateTimeKind.Local).AddTicks(929), new DateTime(2025, 2, 8, 21, 22, 27, 266, DateTimeKind.Local).AddTicks(930), new DateTime(2025, 2, 8, 21, 22, 27, 266, DateTimeKind.Local).AddTicks(928), 1, "12:30", "System" },
                    { 2, null, "System", "2", null, new DateTime(2025, 2, 8, 21, 22, 27, 266, DateTimeKind.Local).AddTicks(932), new DateTime(2025, 2, 8, 21, 22, 27, 266, DateTimeKind.Local).AddTicks(932), new DateTime(2025, 2, 8, 21, 22, 27, 266, DateTimeKind.Local).AddTicks(931), 2, "12:30", "System" }
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
