using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 15, 27, 251, DateTimeKind.Local).AddTicks(2584), new DateTime(2024, 11, 27, 21, 15, 27, 251, DateTimeKind.Local).AddTicks(2595) });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 15, 27, 251, DateTimeKind.Local).AddTicks(2596), new DateTime(2024, 11, 27, 21, 15, 27, 251, DateTimeKind.Local).AddTicks(2597) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 15, 27, 251, DateTimeKind.Local).AddTicks(2710), new DateTime(2024, 11, 27, 21, 15, 27, 251, DateTimeKind.Local).AddTicks(2711) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 15, 27, 251, DateTimeKind.Local).AddTicks(2712), new DateTime(2024, 11, 27, 21, 15, 27, 251, DateTimeKind.Local).AddTicks(2712) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ReservedDateTime" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 15, 27, 251, DateTimeKind.Local).AddTicks(2782), new DateTime(2024, 11, 27, 21, 15, 27, 251, DateTimeKind.Local).AddTicks(2783), new DateTime(2024, 11, 27, 21, 15, 27, 251, DateTimeKind.Local).AddTicks(2781) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ReservedDateTime" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 15, 27, 251, DateTimeKind.Local).AddTicks(2785), new DateTime(2024, 11, 27, 21, 15, 27, 251, DateTimeKind.Local).AddTicks(2785), new DateTime(2024, 11, 27, 21, 15, 27, 251, DateTimeKind.Local).AddTicks(2784) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 15, 27, 251, DateTimeKind.Local).AddTicks(2843), new DateTime(2024, 11, 27, 21, 15, 27, 251, DateTimeKind.Local).AddTicks(2843) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 15, 27, 251, DateTimeKind.Local).AddTicks(2845), new DateTime(2024, 11, 27, 21, 15, 27, 251, DateTimeKind.Local).AddTicks(2845) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 15, 27, 251, DateTimeKind.Local).AddTicks(2900), new DateTime(2024, 11, 27, 21, 15, 27, 251, DateTimeKind.Local).AddTicks(2900) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 15, 27, 251, DateTimeKind.Local).AddTicks(2901), new DateTime(2024, 11, 27, 21, 15, 27, 251, DateTimeKind.Local).AddTicks(2902) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 15, 27, 251, DateTimeKind.Local).AddTicks(2903), new DateTime(2024, 11, 27, 21, 15, 27, 251, DateTimeKind.Local).AddTicks(2903) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 15, 27, 251, DateTimeKind.Local).AddTicks(2904), new DateTime(2024, 11, 27, 21, 15, 27, 251, DateTimeKind.Local).AddTicks(2904) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 15, 27, 251, DateTimeKind.Local).AddTicks(2905), new DateTime(2024, 11, 27, 21, 15, 27, 251, DateTimeKind.Local).AddTicks(2906) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 15, 27, 251, DateTimeKind.Local).AddTicks(2906), new DateTime(2024, 11, 27, 21, 15, 27, 251, DateTimeKind.Local).AddTicks(2907) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 15, 27, 251, DateTimeKind.Local).AddTicks(2908), new DateTime(2024, 11, 27, 21, 15, 27, 251, DateTimeKind.Local).AddTicks(2908) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 15, 27, 251, DateTimeKind.Local).AddTicks(2909), new DateTime(2024, 11, 27, 21, 15, 27, 251, DateTimeKind.Local).AddTicks(2909) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 15, 27, 251, DateTimeKind.Local).AddTicks(2910), new DateTime(2024, 11, 27, 21, 15, 27, 251, DateTimeKind.Local).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 15, 27, 251, DateTimeKind.Local).AddTicks(2911), new DateTime(2024, 11, 27, 21, 15, 27, 251, DateTimeKind.Local).AddTicks(2912) });
        }
    }
}
