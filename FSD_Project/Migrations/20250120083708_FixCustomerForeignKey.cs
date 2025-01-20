using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project.Migrations
{
    /// <inheritdoc />
    public partial class FixCustomerForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d74750a0-b59f-4401-9ef0-b29e87727c60", "AQAAAAIAAYagAAAAEFZrh6ikFIBjSh2egeoXZbFHl1ee8nYioUb03WUUWkEEfT6vhYRw9No+vOxjZiAD0g==", "97eeb42c-8532-46a0-b582-09bf42e5e8c3" });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 26, 28, 788, DateTimeKind.Local).AddTicks(390), new DateTime(2025, 1, 20, 16, 26, 28, 788, DateTimeKind.Local).AddTicks(404) });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 26, 28, 788, DateTimeKind.Local).AddTicks(409), new DateTime(2025, 1, 20, 16, 26, 28, 788, DateTimeKind.Local).AddTicks(410) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 26, 28, 788, DateTimeKind.Local).AddTicks(858), new DateTime(2025, 1, 20, 16, 26, 28, 788, DateTimeKind.Local).AddTicks(860) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 26, 28, 788, DateTimeKind.Local).AddTicks(863), new DateTime(2025, 1, 20, 16, 26, 28, 788, DateTimeKind.Local).AddTicks(865) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ReservedDateTime" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 26, 28, 788, DateTimeKind.Local).AddTicks(1054), new DateTime(2025, 1, 20, 16, 26, 28, 788, DateTimeKind.Local).AddTicks(1055), new DateTime(2025, 1, 20, 16, 26, 28, 788, DateTimeKind.Local).AddTicks(1051) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ReservedDateTime" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 26, 28, 788, DateTimeKind.Local).AddTicks(1060), new DateTime(2025, 1, 20, 16, 26, 28, 788, DateTimeKind.Local).AddTicks(1061), new DateTime(2025, 1, 20, 16, 26, 28, 788, DateTimeKind.Local).AddTicks(1058) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 26, 28, 788, DateTimeKind.Local).AddTicks(1495), new DateTime(2025, 1, 20, 16, 26, 28, 788, DateTimeKind.Local).AddTicks(1496) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 26, 28, 788, DateTimeKind.Local).AddTicks(1500), new DateTime(2025, 1, 20, 16, 26, 28, 788, DateTimeKind.Local).AddTicks(1501) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 26, 28, 788, DateTimeKind.Local).AddTicks(1763), new DateTime(2025, 1, 20, 16, 26, 28, 788, DateTimeKind.Local).AddTicks(1764) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 26, 28, 788, DateTimeKind.Local).AddTicks(1768), new DateTime(2025, 1, 20, 16, 26, 28, 788, DateTimeKind.Local).AddTicks(1769) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 26, 28, 788, DateTimeKind.Local).AddTicks(1773), new DateTime(2025, 1, 20, 16, 26, 28, 788, DateTimeKind.Local).AddTicks(1774) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 26, 28, 788, DateTimeKind.Local).AddTicks(1777), new DateTime(2025, 1, 20, 16, 26, 28, 788, DateTimeKind.Local).AddTicks(1779) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 26, 28, 788, DateTimeKind.Local).AddTicks(1782), new DateTime(2025, 1, 20, 16, 26, 28, 788, DateTimeKind.Local).AddTicks(1783) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 26, 28, 788, DateTimeKind.Local).AddTicks(1787), new DateTime(2025, 1, 20, 16, 26, 28, 788, DateTimeKind.Local).AddTicks(1788) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 26, 28, 788, DateTimeKind.Local).AddTicks(1792), new DateTime(2025, 1, 20, 16, 26, 28, 788, DateTimeKind.Local).AddTicks(1793) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 26, 28, 788, DateTimeKind.Local).AddTicks(1796), new DateTime(2025, 1, 20, 16, 26, 28, 788, DateTimeKind.Local).AddTicks(1798) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 26, 28, 788, DateTimeKind.Local).AddTicks(1801), new DateTime(2025, 1, 20, 16, 26, 28, 788, DateTimeKind.Local).AddTicks(1802) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 26, 28, 788, DateTimeKind.Local).AddTicks(1806), new DateTime(2025, 1, 20, 16, 26, 28, 788, DateTimeKind.Local).AddTicks(1807) });
        }
    }
}
