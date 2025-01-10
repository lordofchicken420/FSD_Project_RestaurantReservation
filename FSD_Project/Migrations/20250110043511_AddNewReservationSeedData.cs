using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project.Migrations
{
    /// <inheritdoc />
    public partial class AddNewReservationSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Pax",
                table: "Reservation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TableID",
                table: "Reservation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumOfTables",
                table: "Branch",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a30e296-c9d4-41f8-9813-312da04ce513", "AQAAAAIAAYagAAAAEA/opOtL5kiEt1Qzqu4ki7awFTjt2oyW7wmzN6Sb4ktEDH5l9G3QRUKZrCvKcKLyqA==", "937feb98-ff3c-4324-a380-c1ec3b3c226e" });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "NumOfTables" },
                values: new object[] { new DateTime(2025, 1, 10, 12, 35, 10, 964, DateTimeKind.Local).AddTicks(6641), new DateTime(2025, 1, 10, 12, 35, 10, 964, DateTimeKind.Local).AddTicks(6653), 15 });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "NumOfTables" },
                values: new object[] { new DateTime(2025, 1, 10, 12, 35, 10, 964, DateTimeKind.Local).AddTicks(6656), new DateTime(2025, 1, 10, 12, 35, 10, 964, DateTimeKind.Local).AddTicks(6657), 15 });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 10, 12, 35, 10, 964, DateTimeKind.Local).AddTicks(6795), new DateTime(2025, 1, 10, 12, 35, 10, 964, DateTimeKind.Local).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 10, 12, 35, 10, 964, DateTimeKind.Local).AddTicks(6797), new DateTime(2025, 1, 10, 12, 35, 10, 964, DateTimeKind.Local).AddTicks(6797) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "Pax", "ReservedDateTime", "TableID" },
                values: new object[] { new DateTime(2025, 1, 10, 12, 35, 10, 964, DateTimeKind.Local).AddTicks(6856), new DateTime(2025, 1, 10, 12, 35, 10, 964, DateTimeKind.Local).AddTicks(6856), 3, new DateTime(2025, 1, 10, 12, 35, 10, 964, DateTimeKind.Local).AddTicks(6855), 0 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Pax", "ReservedDateTime", "TableID" },
                values: new object[] { new DateTime(2025, 1, 10, 12, 35, 10, 964, DateTimeKind.Local).AddTicks(6858), new DateTime(2025, 1, 10, 12, 35, 10, 964, DateTimeKind.Local).AddTicks(6859), 2, new DateTime(2025, 1, 10, 12, 35, 10, 964, DateTimeKind.Local).AddTicks(6858), 0 });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 10, 12, 35, 10, 964, DateTimeKind.Local).AddTicks(6923), new DateTime(2025, 1, 10, 12, 35, 10, 964, DateTimeKind.Local).AddTicks(6924) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 10, 12, 35, 10, 964, DateTimeKind.Local).AddTicks(6925), new DateTime(2025, 1, 10, 12, 35, 10, 964, DateTimeKind.Local).AddTicks(6926) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 10, 12, 35, 10, 964, DateTimeKind.Local).AddTicks(6985), new DateTime(2025, 1, 10, 12, 35, 10, 964, DateTimeKind.Local).AddTicks(6986) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 10, 12, 35, 10, 964, DateTimeKind.Local).AddTicks(6987), new DateTime(2025, 1, 10, 12, 35, 10, 964, DateTimeKind.Local).AddTicks(6988) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 10, 12, 35, 10, 964, DateTimeKind.Local).AddTicks(6989), new DateTime(2025, 1, 10, 12, 35, 10, 964, DateTimeKind.Local).AddTicks(6990) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 10, 12, 35, 10, 964, DateTimeKind.Local).AddTicks(6991), new DateTime(2025, 1, 10, 12, 35, 10, 964, DateTimeKind.Local).AddTicks(6991) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 10, 12, 35, 10, 964, DateTimeKind.Local).AddTicks(6992), new DateTime(2025, 1, 10, 12, 35, 10, 964, DateTimeKind.Local).AddTicks(6993) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 10, 12, 35, 10, 964, DateTimeKind.Local).AddTicks(6994), new DateTime(2025, 1, 10, 12, 35, 10, 964, DateTimeKind.Local).AddTicks(6994) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 10, 12, 35, 10, 964, DateTimeKind.Local).AddTicks(6995), new DateTime(2025, 1, 10, 12, 35, 10, 964, DateTimeKind.Local).AddTicks(6996) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 10, 12, 35, 10, 964, DateTimeKind.Local).AddTicks(6997), new DateTime(2025, 1, 10, 12, 35, 10, 964, DateTimeKind.Local).AddTicks(6997) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 10, 12, 35, 10, 964, DateTimeKind.Local).AddTicks(7044), new DateTime(2025, 1, 10, 12, 35, 10, 964, DateTimeKind.Local).AddTicks(7044) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 10, 12, 35, 10, 964, DateTimeKind.Local).AddTicks(7045), new DateTime(2025, 1, 10, 12, 35, 10, 964, DateTimeKind.Local).AddTicks(7046) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pax",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "TableID",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "NumOfTables",
                table: "Branch");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbf0b1f8-1ab5-43f5-be5c-d718e4050839", "AQAAAAIAAYagAAAAEDCwB9Iv3ku9Jkh+tmfzK/McIcB72/daGbk9aM9JXQrE24VQ0VTDkUbzlijKNR4KIQ==", "32c3de5c-6cd2-4736-91e1-45ce7ceba4de" });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 56, 22, 666, DateTimeKind.Local).AddTicks(8006), new DateTime(2024, 11, 27, 22, 56, 22, 666, DateTimeKind.Local).AddTicks(8015) });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 56, 22, 666, DateTimeKind.Local).AddTicks(8017), new DateTime(2024, 11, 27, 22, 56, 22, 666, DateTimeKind.Local).AddTicks(8018) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 56, 22, 666, DateTimeKind.Local).AddTicks(8169), new DateTime(2024, 11, 27, 22, 56, 22, 666, DateTimeKind.Local).AddTicks(8169) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 56, 22, 666, DateTimeKind.Local).AddTicks(8171), new DateTime(2024, 11, 27, 22, 56, 22, 666, DateTimeKind.Local).AddTicks(8171) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ReservedDateTime" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 56, 22, 666, DateTimeKind.Local).AddTicks(8241), new DateTime(2024, 11, 27, 22, 56, 22, 666, DateTimeKind.Local).AddTicks(8241), new DateTime(2024, 11, 27, 22, 56, 22, 666, DateTimeKind.Local).AddTicks(8240) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ReservedDateTime" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 56, 22, 666, DateTimeKind.Local).AddTicks(8243), new DateTime(2024, 11, 27, 22, 56, 22, 666, DateTimeKind.Local).AddTicks(8244), new DateTime(2024, 11, 27, 22, 56, 22, 666, DateTimeKind.Local).AddTicks(8243) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 56, 22, 666, DateTimeKind.Local).AddTicks(8314), new DateTime(2024, 11, 27, 22, 56, 22, 666, DateTimeKind.Local).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 56, 22, 666, DateTimeKind.Local).AddTicks(8317), new DateTime(2024, 11, 27, 22, 56, 22, 666, DateTimeKind.Local).AddTicks(8317) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 56, 22, 666, DateTimeKind.Local).AddTicks(8378), new DateTime(2024, 11, 27, 22, 56, 22, 666, DateTimeKind.Local).AddTicks(8379) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 56, 22, 666, DateTimeKind.Local).AddTicks(8380), new DateTime(2024, 11, 27, 22, 56, 22, 666, DateTimeKind.Local).AddTicks(8380) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 56, 22, 666, DateTimeKind.Local).AddTicks(8382), new DateTime(2024, 11, 27, 22, 56, 22, 666, DateTimeKind.Local).AddTicks(8382) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 56, 22, 666, DateTimeKind.Local).AddTicks(8383), new DateTime(2024, 11, 27, 22, 56, 22, 666, DateTimeKind.Local).AddTicks(8384) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 56, 22, 666, DateTimeKind.Local).AddTicks(8385), new DateTime(2024, 11, 27, 22, 56, 22, 666, DateTimeKind.Local).AddTicks(8385) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 56, 22, 666, DateTimeKind.Local).AddTicks(8386), new DateTime(2024, 11, 27, 22, 56, 22, 666, DateTimeKind.Local).AddTicks(8387) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 56, 22, 666, DateTimeKind.Local).AddTicks(8388), new DateTime(2024, 11, 27, 22, 56, 22, 666, DateTimeKind.Local).AddTicks(8388) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 56, 22, 666, DateTimeKind.Local).AddTicks(8420), new DateTime(2024, 11, 27, 22, 56, 22, 666, DateTimeKind.Local).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 56, 22, 666, DateTimeKind.Local).AddTicks(8422), new DateTime(2024, 11, 27, 22, 56, 22, 666, DateTimeKind.Local).AddTicks(8422) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 56, 22, 666, DateTimeKind.Local).AddTicks(8423), new DateTime(2024, 11, 27, 22, 56, 22, 666, DateTimeKind.Local).AddTicks(8424) });
        }
    }
}
