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
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contactNumber = table.Column<int>(type: "int", nullable: false),
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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "456cc0ad-4c2c-46b7-98d9-4d66e6f877e4", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEDA0d9b2fLN7UY4zPP8sTavN4mMjw1IVz/ITkHbVCry2rygKBOo4qKaa2WA1IlAA1g==", null, false, "59dee051-65d5-41a4-9024-ec53ffa74f6b", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Branch",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Location", "Name", "NumOfTables", "UpdatedBy", "contactNumber" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 1, 20, 22, 15, 32, 16, DateTimeKind.Local).AddTicks(3602), new DateTime(2025, 1, 20, 22, 15, 32, 16, DateTimeKind.Local).AddTicks(3611), "Woodlands", "Branch 1", 15, "System", 61234567 },
                    { 2, "System", new DateTime(2025, 1, 20, 22, 15, 32, 16, DateTimeKind.Local).AddTicks(3613), new DateTime(2025, 1, 20, 22, 15, 32, 16, DateTimeKind.Local).AddTicks(3613), "Punggol", "Branch 2", 15, "System", 61234566 }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Gender", "Name", "UpdatedBy", "contactNumber" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 1, 20, 22, 15, 32, 16, DateTimeKind.Local).AddTicks(3737), new DateTime(2025, 1, 20, 22, 15, 32, 16, DateTimeKind.Local).AddTicks(3738), "Male", "David Lee", "System", 91234567 },
                    { 2, "System", new DateTime(2025, 1, 20, 22, 15, 32, 16, DateTimeKind.Local).AddTicks(3739), new DateTime(2025, 1, 20, 22, 15, 32, 16, DateTimeKind.Local).AddTicks(3740), "Male", "John Matthew", "System", 91234566 }
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
                    { 1, 1, "System", new DateTime(2025, 1, 20, 22, 15, 32, 16, DateTimeKind.Local).AddTicks(3884), new DateTime(2025, 1, 20, 22, 15, 32, 16, DateTimeKind.Local).AddTicks(3884), "Male", "Gordon Sim", "System", 97581578 },
                    { 2, 1, "System", new DateTime(2025, 1, 20, 22, 15, 32, 16, DateTimeKind.Local).AddTicks(3885), new DateTime(2025, 1, 20, 22, 15, 32, 16, DateTimeKind.Local).AddTicks(3886), "Female", "En Xuan", "System", 98886482 }
                });

            migrationBuilder.InsertData(
                table: "Table",
                columns: new[] { "Id", "BranchId", "Capacity", "CreatedBy", "DateCreated", "DateUpdated", "Status", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, 10, "System", new DateTime(2025, 1, 20, 22, 15, 32, 16, DateTimeKind.Local).AddTicks(3970), new DateTime(2025, 1, 20, 22, 15, 32, 16, DateTimeKind.Local).AddTicks(3970), true, "System" },
                    { 2, 1, 10, "System", new DateTime(2025, 1, 20, 22, 15, 32, 16, DateTimeKind.Local).AddTicks(3972), new DateTime(2025, 1, 20, 22, 15, 32, 16, DateTimeKind.Local).AddTicks(3972), true, "System" },
                    { 3, 1, 10, "System", new DateTime(2025, 1, 20, 22, 15, 32, 16, DateTimeKind.Local).AddTicks(3974), new DateTime(2025, 1, 20, 22, 15, 32, 16, DateTimeKind.Local).AddTicks(3974), true, "System" },
                    { 4, 1, 10, "System", new DateTime(2025, 1, 20, 22, 15, 32, 16, DateTimeKind.Local).AddTicks(3975), new DateTime(2025, 1, 20, 22, 15, 32, 16, DateTimeKind.Local).AddTicks(3975), true, "System" },
                    { 5, 1, 10, "System", new DateTime(2025, 1, 20, 22, 15, 32, 16, DateTimeKind.Local).AddTicks(3976), new DateTime(2025, 1, 20, 22, 15, 32, 16, DateTimeKind.Local).AddTicks(3977), true, "System" },
                    { 6, 1, 10, "System", new DateTime(2025, 1, 20, 22, 15, 32, 16, DateTimeKind.Local).AddTicks(3978), new DateTime(2025, 1, 20, 22, 15, 32, 16, DateTimeKind.Local).AddTicks(3978), true, "System" },
                    { 7, 1, 10, "System", new DateTime(2025, 1, 20, 22, 15, 32, 16, DateTimeKind.Local).AddTicks(3979), new DateTime(2025, 1, 20, 22, 15, 32, 16, DateTimeKind.Local).AddTicks(3979), true, "System" },
                    { 8, 1, 10, "System", new DateTime(2025, 1, 20, 22, 15, 32, 16, DateTimeKind.Local).AddTicks(3980), new DateTime(2025, 1, 20, 22, 15, 32, 16, DateTimeKind.Local).AddTicks(3981), true, "System" },
                    { 9, 1, 10, "System", new DateTime(2025, 1, 20, 22, 15, 32, 16, DateTimeKind.Local).AddTicks(3982), new DateTime(2025, 1, 20, 22, 15, 32, 16, DateTimeKind.Local).AddTicks(3982), true, "System" },
                    { 10, 1, 10, "System", new DateTime(2025, 1, 20, 22, 15, 32, 16, DateTimeKind.Local).AddTicks(3983), new DateTime(2025, 1, 20, 22, 15, 32, 16, DateTimeKind.Local).AddTicks(3983), true, "System" }
                });

            migrationBuilder.InsertData(
                table: "Reservation",
                columns: new[] { "Id", "BranchId", "CreatedBy", "CustomerId", "CustomerId1", "DateCreated", "DateUpdated", "Pax", "ReservedDateTime", "TableID", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, "System", "1", null, new DateTime(2025, 1, 20, 22, 15, 32, 16, DateTimeKind.Local).AddTicks(3793), new DateTime(2025, 1, 20, 22, 15, 32, 16, DateTimeKind.Local).AddTicks(3793), 3, new DateTime(2025, 1, 20, 22, 15, 32, 16, DateTimeKind.Local).AddTicks(3792), 1, "System" },
                    { 2, null, "System", "2", null, new DateTime(2025, 1, 20, 22, 15, 32, 16, DateTimeKind.Local).AddTicks(3795), new DateTime(2025, 1, 20, 22, 15, 32, 16, DateTimeKind.Local).AddTicks(3795), 2, new DateTime(2025, 1, 20, 22, 15, 32, 16, DateTimeKind.Local).AddTicks(3794), 2, "System" }
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
