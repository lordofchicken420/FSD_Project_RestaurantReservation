using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project.Migrations
{
    /// <inheritdoc />
    public partial class UpdateReservationTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1eac2c0a-7d47-4c36-a0da-dddff9f07c13", "AQAAAAIAAYagAAAAEI9SXiPAr6Ionnveqctf/TYnTv+k2PjeMUlj1dckmCzK4C9jQgXUbkAdVu02YQyodg==", "7d7a54aa-249f-46d4-87c6-e70b4caa5c26" });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(3062), new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(3076) });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(3081), new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(3082) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(3521), new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(3522) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(3526), new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(3527) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ReservedDateTime" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(3716), new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(3717), new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(3713) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ReservedDateTime" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(3722), new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(3724), new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(3720) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(3923), new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(3924) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(3928), new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(3929) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(4117), new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(4118) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(4122), new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(4123) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(4127), new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(4128) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(4132), new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(4133) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(4137), new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(4138) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(4142), new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(4143) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(4147), new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(4148) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(4151), new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(4152) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(4156), new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(4157) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(4161), new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(4162) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "730bd166-b8fe-42f8-81d5-b9e64547ea12", "AQAAAAIAAYagAAAAECkvazfE8OeH86qA6dgTAU+wUazOqqlZ5M0rLDhRrk92KA5PxUFiRe/pnXQC/Agecg==", "b0b7c5de-e3e9-4c4d-bba4-e4f9281d0ce6" });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(1884), new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(1897) });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(1903), new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(1904) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(2382), new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(2384) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(2388), new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(2389) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ReservedDateTime" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(2756), new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(2757), new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(2752) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ReservedDateTime" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(2762), new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(2763), new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(2760) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(2960), new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(2962) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(2965), new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(2967) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(3173), new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(3175) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(3179), new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(3180) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(3184), new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(3185) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(3189), new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(3190) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(3208), new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(3209) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(3213), new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(3219) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(3242), new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(3244) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(3248), new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(3249) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(3253), new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(3258), new DateTime(2025, 1, 20, 16, 37, 6, 519, DateTimeKind.Local).AddTicks(3259) });
        }
    }
}
