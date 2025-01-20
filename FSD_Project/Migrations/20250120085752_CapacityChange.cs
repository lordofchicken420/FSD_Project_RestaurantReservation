using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project.Migrations
{
    /// <inheritdoc />
    public partial class CapacityChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b782f98-44d2-4950-a6aa-a582532f0d7a", "AQAAAAIAAYagAAAAEMisJ9tNahRyEO9lbmH4XIBN9abDxGhodjJ+ycjzTahFgq5X79Sr1IMT0FdeGVy81w==", "1db3079b-12e2-4fe2-9dc0-3ec5789e67a2" });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 57, 50, 242, DateTimeKind.Local).AddTicks(5769), new DateTime(2025, 1, 20, 16, 57, 50, 242, DateTimeKind.Local).AddTicks(5784) });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 57, 50, 242, DateTimeKind.Local).AddTicks(5789), new DateTime(2025, 1, 20, 16, 57, 50, 242, DateTimeKind.Local).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 57, 50, 242, DateTimeKind.Local).AddTicks(6276), new DateTime(2025, 1, 20, 16, 57, 50, 242, DateTimeKind.Local).AddTicks(6277) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 57, 50, 242, DateTimeKind.Local).AddTicks(6281), new DateTime(2025, 1, 20, 16, 57, 50, 242, DateTimeKind.Local).AddTicks(6282) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ReservedDateTime" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 57, 50, 242, DateTimeKind.Local).AddTicks(6687), new DateTime(2025, 1, 20, 16, 57, 50, 242, DateTimeKind.Local).AddTicks(6688), new DateTime(2025, 1, 20, 16, 57, 50, 242, DateTimeKind.Local).AddTicks(6684) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ReservedDateTime" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 57, 50, 242, DateTimeKind.Local).AddTicks(6693), new DateTime(2025, 1, 20, 16, 57, 50, 242, DateTimeKind.Local).AddTicks(6695), new DateTime(2025, 1, 20, 16, 57, 50, 242, DateTimeKind.Local).AddTicks(6691) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 57, 50, 242, DateTimeKind.Local).AddTicks(6918), new DateTime(2025, 1, 20, 16, 57, 50, 242, DateTimeKind.Local).AddTicks(6919) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 57, 50, 242, DateTimeKind.Local).AddTicks(6923), new DateTime(2025, 1, 20, 16, 57, 50, 242, DateTimeKind.Local).AddTicks(6924) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Capacity", "DateCreated", "DateUpdated" },
                values: new object[] { 10, new DateTime(2025, 1, 20, 16, 57, 50, 242, DateTimeKind.Local).AddTicks(7128), new DateTime(2025, 1, 20, 16, 57, 50, 242, DateTimeKind.Local).AddTicks(7129) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Capacity", "DateCreated", "DateUpdated" },
                values: new object[] { 10, new DateTime(2025, 1, 20, 16, 57, 50, 242, DateTimeKind.Local).AddTicks(7133), new DateTime(2025, 1, 20, 16, 57, 50, 242, DateTimeKind.Local).AddTicks(7134) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Capacity", "DateCreated", "DateUpdated" },
                values: new object[] { 10, new DateTime(2025, 1, 20, 16, 57, 50, 242, DateTimeKind.Local).AddTicks(7138), new DateTime(2025, 1, 20, 16, 57, 50, 242, DateTimeKind.Local).AddTicks(7139) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Capacity", "DateCreated", "DateUpdated" },
                values: new object[] { 10, new DateTime(2025, 1, 20, 16, 57, 50, 242, DateTimeKind.Local).AddTicks(7143), new DateTime(2025, 1, 20, 16, 57, 50, 242, DateTimeKind.Local).AddTicks(7144) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Capacity", "DateCreated", "DateUpdated" },
                values: new object[] { 10, new DateTime(2025, 1, 20, 16, 57, 50, 242, DateTimeKind.Local).AddTicks(7160), new DateTime(2025, 1, 20, 16, 57, 50, 242, DateTimeKind.Local).AddTicks(7162) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Capacity", "DateCreated", "DateUpdated" },
                values: new object[] { 10, new DateTime(2025, 1, 20, 16, 57, 50, 242, DateTimeKind.Local).AddTicks(7166), new DateTime(2025, 1, 20, 16, 57, 50, 242, DateTimeKind.Local).AddTicks(7176) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Capacity", "DateCreated", "DateUpdated" },
                values: new object[] { 10, new DateTime(2025, 1, 20, 16, 57, 50, 242, DateTimeKind.Local).AddTicks(7194), new DateTime(2025, 1, 20, 16, 57, 50, 242, DateTimeKind.Local).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Capacity", "DateCreated", "DateUpdated" },
                values: new object[] { 10, new DateTime(2025, 1, 20, 16, 57, 50, 242, DateTimeKind.Local).AddTicks(7200), new DateTime(2025, 1, 20, 16, 57, 50, 242, DateTimeKind.Local).AddTicks(7202) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Capacity", "DateCreated", "DateUpdated" },
                values: new object[] { 10, new DateTime(2025, 1, 20, 16, 57, 50, 242, DateTimeKind.Local).AddTicks(7205), new DateTime(2025, 1, 20, 16, 57, 50, 242, DateTimeKind.Local).AddTicks(7207) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Capacity", "DateCreated", "DateUpdated" },
                values: new object[] { 10, new DateTime(2025, 1, 20, 16, 57, 50, 242, DateTimeKind.Local).AddTicks(7210), new DateTime(2025, 1, 20, 16, 57, 50, 242, DateTimeKind.Local).AddTicks(7212) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "Capacity", "DateCreated", "DateUpdated" },
                values: new object[] { 5, new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(4117), new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(4118) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Capacity", "DateCreated", "DateUpdated" },
                values: new object[] { 5, new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(4122), new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(4123) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Capacity", "DateCreated", "DateUpdated" },
                values: new object[] { 5, new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(4127), new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(4128) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Capacity", "DateCreated", "DateUpdated" },
                values: new object[] { 5, new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(4132), new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(4133) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Capacity", "DateCreated", "DateUpdated" },
                values: new object[] { 5, new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(4137), new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(4138) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Capacity", "DateCreated", "DateUpdated" },
                values: new object[] { 5, new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(4142), new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(4143) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Capacity", "DateCreated", "DateUpdated" },
                values: new object[] { 5, new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(4147), new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(4148) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Capacity", "DateCreated", "DateUpdated" },
                values: new object[] { 5, new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(4151), new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(4152) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Capacity", "DateCreated", "DateUpdated" },
                values: new object[] { 5, new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(4156), new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(4157) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Capacity", "DateCreated", "DateUpdated" },
                values: new object[] { 5, new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(4161), new DateTime(2025, 1, 20, 16, 38, 10, 2, DateTimeKind.Local).AddTicks(4162) });
        }
    }
}
