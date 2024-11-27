using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FSD_Project.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRoleAgainn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "8f7b5d1b-a7f2-478c-8067-2ee72d667ada", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAECuJDmzfFh5VGhhPFIMiYcJ+tChxoU7RPFK9wJdrPHBb7AY68E5NlNLUZ4VrVUTuXQ==", null, false, "c86fbf81-1f89-497b-8d2e-9096b5b37534", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 42, 27, 690, DateTimeKind.Local).AddTicks(8059), new DateTime(2024, 11, 27, 21, 42, 27, 690, DateTimeKind.Local).AddTicks(8068) });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 42, 27, 690, DateTimeKind.Local).AddTicks(8069), new DateTime(2024, 11, 27, 21, 42, 27, 690, DateTimeKind.Local).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 42, 27, 690, DateTimeKind.Local).AddTicks(8197), new DateTime(2024, 11, 27, 21, 42, 27, 690, DateTimeKind.Local).AddTicks(8198) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 42, 27, 690, DateTimeKind.Local).AddTicks(8199), new DateTime(2024, 11, 27, 21, 42, 27, 690, DateTimeKind.Local).AddTicks(8199) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ReservedDateTime" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 42, 27, 690, DateTimeKind.Local).AddTicks(8264), new DateTime(2024, 11, 27, 21, 42, 27, 690, DateTimeKind.Local).AddTicks(8264), new DateTime(2024, 11, 27, 21, 42, 27, 690, DateTimeKind.Local).AddTicks(8263) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ReservedDateTime" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 42, 27, 690, DateTimeKind.Local).AddTicks(8266), new DateTime(2024, 11, 27, 21, 42, 27, 690, DateTimeKind.Local).AddTicks(8266), new DateTime(2024, 11, 27, 21, 42, 27, 690, DateTimeKind.Local).AddTicks(8265) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 42, 27, 690, DateTimeKind.Local).AddTicks(8316), new DateTime(2024, 11, 27, 21, 42, 27, 690, DateTimeKind.Local).AddTicks(8316) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 42, 27, 690, DateTimeKind.Local).AddTicks(8318), new DateTime(2024, 11, 27, 21, 42, 27, 690, DateTimeKind.Local).AddTicks(8318) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 42, 27, 690, DateTimeKind.Local).AddTicks(8369), new DateTime(2024, 11, 27, 21, 42, 27, 690, DateTimeKind.Local).AddTicks(8370) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 42, 27, 690, DateTimeKind.Local).AddTicks(8371), new DateTime(2024, 11, 27, 21, 42, 27, 690, DateTimeKind.Local).AddTicks(8372) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 42, 27, 690, DateTimeKind.Local).AddTicks(8373), new DateTime(2024, 11, 27, 21, 42, 27, 690, DateTimeKind.Local).AddTicks(8373) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 42, 27, 690, DateTimeKind.Local).AddTicks(8374), new DateTime(2024, 11, 27, 21, 42, 27, 690, DateTimeKind.Local).AddTicks(8374) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 42, 27, 690, DateTimeKind.Local).AddTicks(8375), new DateTime(2024, 11, 27, 21, 42, 27, 690, DateTimeKind.Local).AddTicks(8375) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 42, 27, 690, DateTimeKind.Local).AddTicks(8376), new DateTime(2024, 11, 27, 21, 42, 27, 690, DateTimeKind.Local).AddTicks(8377) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 42, 27, 690, DateTimeKind.Local).AddTicks(8378), new DateTime(2024, 11, 27, 21, 42, 27, 690, DateTimeKind.Local).AddTicks(8378) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 42, 27, 690, DateTimeKind.Local).AddTicks(8379), new DateTime(2024, 11, 27, 21, 42, 27, 690, DateTimeKind.Local).AddTicks(8379) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 42, 27, 690, DateTimeKind.Local).AddTicks(8380), new DateTime(2024, 11, 27, 21, 42, 27, 690, DateTimeKind.Local).AddTicks(8380) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 42, 27, 690, DateTimeKind.Local).AddTicks(8381), new DateTime(2024, 11, 27, 21, 42, 27, 690, DateTimeKind.Local).AddTicks(8382) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 36, 8, 37, DateTimeKind.Local).AddTicks(9339), new DateTime(2024, 11, 27, 21, 36, 8, 37, DateTimeKind.Local).AddTicks(9347) });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 36, 8, 37, DateTimeKind.Local).AddTicks(9348), new DateTime(2024, 11, 27, 21, 36, 8, 37, DateTimeKind.Local).AddTicks(9349) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 36, 8, 37, DateTimeKind.Local).AddTicks(9465), new DateTime(2024, 11, 27, 21, 36, 8, 37, DateTimeKind.Local).AddTicks(9465) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 36, 8, 37, DateTimeKind.Local).AddTicks(9466), new DateTime(2024, 11, 27, 21, 36, 8, 37, DateTimeKind.Local).AddTicks(9467) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ReservedDateTime" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 36, 8, 37, DateTimeKind.Local).AddTicks(9519), new DateTime(2024, 11, 27, 21, 36, 8, 37, DateTimeKind.Local).AddTicks(9520), new DateTime(2024, 11, 27, 21, 36, 8, 37, DateTimeKind.Local).AddTicks(9519) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ReservedDateTime" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 36, 8, 37, DateTimeKind.Local).AddTicks(9521), new DateTime(2024, 11, 27, 21, 36, 8, 37, DateTimeKind.Local).AddTicks(9522), new DateTime(2024, 11, 27, 21, 36, 8, 37, DateTimeKind.Local).AddTicks(9521) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 36, 8, 37, DateTimeKind.Local).AddTicks(9570), new DateTime(2024, 11, 27, 21, 36, 8, 37, DateTimeKind.Local).AddTicks(9571) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 36, 8, 37, DateTimeKind.Local).AddTicks(9572), new DateTime(2024, 11, 27, 21, 36, 8, 37, DateTimeKind.Local).AddTicks(9573) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 36, 8, 37, DateTimeKind.Local).AddTicks(9634), new DateTime(2024, 11, 27, 21, 36, 8, 37, DateTimeKind.Local).AddTicks(9634) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 36, 8, 37, DateTimeKind.Local).AddTicks(9635), new DateTime(2024, 11, 27, 21, 36, 8, 37, DateTimeKind.Local).AddTicks(9636) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 36, 8, 37, DateTimeKind.Local).AddTicks(9637), new DateTime(2024, 11, 27, 21, 36, 8, 37, DateTimeKind.Local).AddTicks(9637) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 36, 8, 37, DateTimeKind.Local).AddTicks(9638), new DateTime(2024, 11, 27, 21, 36, 8, 37, DateTimeKind.Local).AddTicks(9638) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 36, 8, 37, DateTimeKind.Local).AddTicks(9639), new DateTime(2024, 11, 27, 21, 36, 8, 37, DateTimeKind.Local).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 36, 8, 37, DateTimeKind.Local).AddTicks(9641), new DateTime(2024, 11, 27, 21, 36, 8, 37, DateTimeKind.Local).AddTicks(9641) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 36, 8, 37, DateTimeKind.Local).AddTicks(9642), new DateTime(2024, 11, 27, 21, 36, 8, 37, DateTimeKind.Local).AddTicks(9642) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 36, 8, 37, DateTimeKind.Local).AddTicks(9643), new DateTime(2024, 11, 27, 21, 36, 8, 37, DateTimeKind.Local).AddTicks(9644) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 36, 8, 37, DateTimeKind.Local).AddTicks(9645), new DateTime(2024, 11, 27, 21, 36, 8, 37, DateTimeKind.Local).AddTicks(9645) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 36, 8, 37, DateTimeKind.Local).AddTicks(9646), new DateTime(2024, 11, 27, 21, 36, 8, 37, DateTimeKind.Local).AddTicks(9646) });
        }
    }
}
