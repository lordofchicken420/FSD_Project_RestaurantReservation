using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRoleAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 32, 10, 313, DateTimeKind.Local).AddTicks(9058), new DateTime(2024, 11, 27, 21, 32, 10, 313, DateTimeKind.Local).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 32, 10, 313, DateTimeKind.Local).AddTicks(9072), new DateTime(2024, 11, 27, 21, 32, 10, 313, DateTimeKind.Local).AddTicks(9072) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 32, 10, 313, DateTimeKind.Local).AddTicks(9220), new DateTime(2024, 11, 27, 21, 32, 10, 313, DateTimeKind.Local).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 32, 10, 313, DateTimeKind.Local).AddTicks(9222), new DateTime(2024, 11, 27, 21, 32, 10, 313, DateTimeKind.Local).AddTicks(9222) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ReservedDateTime" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 32, 10, 313, DateTimeKind.Local).AddTicks(9281), new DateTime(2024, 11, 27, 21, 32, 10, 313, DateTimeKind.Local).AddTicks(9281), new DateTime(2024, 11, 27, 21, 32, 10, 313, DateTimeKind.Local).AddTicks(9279) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ReservedDateTime" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 32, 10, 313, DateTimeKind.Local).AddTicks(9283), new DateTime(2024, 11, 27, 21, 32, 10, 313, DateTimeKind.Local).AddTicks(9283), new DateTime(2024, 11, 27, 21, 32, 10, 313, DateTimeKind.Local).AddTicks(9282) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 32, 10, 313, DateTimeKind.Local).AddTicks(9337), new DateTime(2024, 11, 27, 21, 32, 10, 313, DateTimeKind.Local).AddTicks(9337) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 32, 10, 313, DateTimeKind.Local).AddTicks(9339), new DateTime(2024, 11, 27, 21, 32, 10, 313, DateTimeKind.Local).AddTicks(9339) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 32, 10, 313, DateTimeKind.Local).AddTicks(9428), new DateTime(2024, 11, 27, 21, 32, 10, 313, DateTimeKind.Local).AddTicks(9428) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 32, 10, 313, DateTimeKind.Local).AddTicks(9430), new DateTime(2024, 11, 27, 21, 32, 10, 313, DateTimeKind.Local).AddTicks(9430) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 32, 10, 313, DateTimeKind.Local).AddTicks(9431), new DateTime(2024, 11, 27, 21, 32, 10, 313, DateTimeKind.Local).AddTicks(9431) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 32, 10, 313, DateTimeKind.Local).AddTicks(9432), new DateTime(2024, 11, 27, 21, 32, 10, 313, DateTimeKind.Local).AddTicks(9432) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 32, 10, 313, DateTimeKind.Local).AddTicks(9433), new DateTime(2024, 11, 27, 21, 32, 10, 313, DateTimeKind.Local).AddTicks(9434) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 32, 10, 313, DateTimeKind.Local).AddTicks(9435), new DateTime(2024, 11, 27, 21, 32, 10, 313, DateTimeKind.Local).AddTicks(9435) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 32, 10, 313, DateTimeKind.Local).AddTicks(9436), new DateTime(2024, 11, 27, 21, 32, 10, 313, DateTimeKind.Local).AddTicks(9436) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 32, 10, 313, DateTimeKind.Local).AddTicks(9437), new DateTime(2024, 11, 27, 21, 32, 10, 313, DateTimeKind.Local).AddTicks(9437) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 32, 10, 313, DateTimeKind.Local).AddTicks(9438), new DateTime(2024, 11, 27, 21, 32, 10, 313, DateTimeKind.Local).AddTicks(9439) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 32, 10, 313, DateTimeKind.Local).AddTicks(9440), new DateTime(2024, 11, 27, 21, 32, 10, 313, DateTimeKind.Local).AddTicks(9440) });
        }
    }
}
