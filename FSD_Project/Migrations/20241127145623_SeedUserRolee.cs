using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRolee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f7b5d1b-a7f2-478c-8067-2ee72d667ada", "AQAAAAIAAYagAAAAECuJDmzfFh5VGhhPFIMiYcJ+tChxoU7RPFK9wJdrPHBb7AY68E5NlNLUZ4VrVUTuXQ==", "c86fbf81-1f89-497b-8d2e-9096b5b37534" });

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
        }
    }
}
