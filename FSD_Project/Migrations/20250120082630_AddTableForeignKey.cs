using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project.Migrations
{
    /// <inheritdoc />
    public partial class AddTableForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d670738-7c66-4a10-8df0-35930645f683", "AQAAAAIAAYagAAAAEJlpOhFToBqDAIixvYAjNCj/mjhJbd6hgMYg+rgwKHCqUUQJtWBWJ/sNDOwT1IUDUw==", "5079d04a-0b6e-4391-b0e1-a549a7e5cc76" });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 17, 9, 530, DateTimeKind.Local).AddTicks(6414), new DateTime(2025, 1, 20, 16, 17, 9, 530, DateTimeKind.Local).AddTicks(6431) });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 17, 9, 530, DateTimeKind.Local).AddTicks(6437), new DateTime(2025, 1, 20, 16, 17, 9, 530, DateTimeKind.Local).AddTicks(6439) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 17, 9, 530, DateTimeKind.Local).AddTicks(7048), new DateTime(2025, 1, 20, 16, 17, 9, 530, DateTimeKind.Local).AddTicks(7050) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 17, 9, 530, DateTimeKind.Local).AddTicks(7055), new DateTime(2025, 1, 20, 16, 17, 9, 530, DateTimeKind.Local).AddTicks(7057) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ReservedDateTime" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 17, 9, 530, DateTimeKind.Local).AddTicks(7305), new DateTime(2025, 1, 20, 16, 17, 9, 530, DateTimeKind.Local).AddTicks(7306), new DateTime(2025, 1, 20, 16, 17, 9, 530, DateTimeKind.Local).AddTicks(7302) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ReservedDateTime" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 17, 9, 530, DateTimeKind.Local).AddTicks(7311), new DateTime(2025, 1, 20, 16, 17, 9, 530, DateTimeKind.Local).AddTicks(7312), new DateTime(2025, 1, 20, 16, 17, 9, 530, DateTimeKind.Local).AddTicks(7309) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 17, 9, 530, DateTimeKind.Local).AddTicks(7815), new DateTime(2025, 1, 20, 16, 17, 9, 530, DateTimeKind.Local).AddTicks(7817) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 17, 9, 530, DateTimeKind.Local).AddTicks(7821), new DateTime(2025, 1, 20, 16, 17, 9, 530, DateTimeKind.Local).AddTicks(7822) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 17, 9, 530, DateTimeKind.Local).AddTicks(8109), new DateTime(2025, 1, 20, 16, 17, 9, 530, DateTimeKind.Local).AddTicks(8111) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 17, 9, 530, DateTimeKind.Local).AddTicks(8116), new DateTime(2025, 1, 20, 16, 17, 9, 530, DateTimeKind.Local).AddTicks(8118) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 17, 9, 530, DateTimeKind.Local).AddTicks(8187), new DateTime(2025, 1, 20, 16, 17, 9, 530, DateTimeKind.Local).AddTicks(8188) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 17, 9, 530, DateTimeKind.Local).AddTicks(8193), new DateTime(2025, 1, 20, 16, 17, 9, 530, DateTimeKind.Local).AddTicks(8195) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 17, 9, 530, DateTimeKind.Local).AddTicks(8199), new DateTime(2025, 1, 20, 16, 17, 9, 530, DateTimeKind.Local).AddTicks(8201) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 17, 9, 530, DateTimeKind.Local).AddTicks(8205), new DateTime(2025, 1, 20, 16, 17, 9, 530, DateTimeKind.Local).AddTicks(8207) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 17, 9, 530, DateTimeKind.Local).AddTicks(8212), new DateTime(2025, 1, 20, 16, 17, 9, 530, DateTimeKind.Local).AddTicks(8213) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 17, 9, 530, DateTimeKind.Local).AddTicks(8218), new DateTime(2025, 1, 20, 16, 17, 9, 530, DateTimeKind.Local).AddTicks(8219) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 17, 9, 530, DateTimeKind.Local).AddTicks(8224), new DateTime(2025, 1, 20, 16, 17, 9, 530, DateTimeKind.Local).AddTicks(8225) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 17, 9, 530, DateTimeKind.Local).AddTicks(8230), new DateTime(2025, 1, 20, 16, 17, 9, 530, DateTimeKind.Local).AddTicks(8232) });
        }
    }
}
