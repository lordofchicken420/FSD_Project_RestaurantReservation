using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project.Migrations
{
    /// <inheritdoc />
    public partial class AddReservationRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db937fb2-78d4-466a-b7db-5ed194dc3f91", "AQAAAAIAAYagAAAAEMTiqK+9K9L2gW4NSPB+AQRPt8+KNoJnwc3o30sGG+aldy5RQohx6KMIJi7P9jJeMg==", "5b536f56-6e36-40cd-a32b-7a9b2313bc7a" });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 15, 12, 617, DateTimeKind.Local).AddTicks(5955), new DateTime(2025, 1, 20, 16, 15, 12, 617, DateTimeKind.Local).AddTicks(5972) });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 15, 12, 617, DateTimeKind.Local).AddTicks(5977), new DateTime(2025, 1, 20, 16, 15, 12, 617, DateTimeKind.Local).AddTicks(5978) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 15, 12, 617, DateTimeKind.Local).AddTicks(6427), new DateTime(2025, 1, 20, 16, 15, 12, 617, DateTimeKind.Local).AddTicks(6429) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 15, 12, 617, DateTimeKind.Local).AddTicks(6433), new DateTime(2025, 1, 20, 16, 15, 12, 617, DateTimeKind.Local).AddTicks(6434) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ReservedDateTime" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 15, 12, 617, DateTimeKind.Local).AddTicks(6640), new DateTime(2025, 1, 20, 16, 15, 12, 617, DateTimeKind.Local).AddTicks(6641), new DateTime(2025, 1, 20, 16, 15, 12, 617, DateTimeKind.Local).AddTicks(6637) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ReservedDateTime" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 15, 12, 617, DateTimeKind.Local).AddTicks(6645), new DateTime(2025, 1, 20, 16, 15, 12, 617, DateTimeKind.Local).AddTicks(6647), new DateTime(2025, 1, 20, 16, 15, 12, 617, DateTimeKind.Local).AddTicks(6643) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 15, 12, 617, DateTimeKind.Local).AddTicks(6831), new DateTime(2025, 1, 20, 16, 15, 12, 617, DateTimeKind.Local).AddTicks(6832) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 15, 12, 617, DateTimeKind.Local).AddTicks(6836), new DateTime(2025, 1, 20, 16, 15, 12, 617, DateTimeKind.Local).AddTicks(6837) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 15, 12, 617, DateTimeKind.Local).AddTicks(7273), new DateTime(2025, 1, 20, 16, 15, 12, 617, DateTimeKind.Local).AddTicks(7275) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 15, 12, 617, DateTimeKind.Local).AddTicks(7278), new DateTime(2025, 1, 20, 16, 15, 12, 617, DateTimeKind.Local).AddTicks(7279) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 15, 12, 617, DateTimeKind.Local).AddTicks(7283), new DateTime(2025, 1, 20, 16, 15, 12, 617, DateTimeKind.Local).AddTicks(7284) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 15, 12, 617, DateTimeKind.Local).AddTicks(7288), new DateTime(2025, 1, 20, 16, 15, 12, 617, DateTimeKind.Local).AddTicks(7289) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 15, 12, 617, DateTimeKind.Local).AddTicks(7293), new DateTime(2025, 1, 20, 16, 15, 12, 617, DateTimeKind.Local).AddTicks(7294) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 15, 12, 617, DateTimeKind.Local).AddTicks(7297), new DateTime(2025, 1, 20, 16, 15, 12, 617, DateTimeKind.Local).AddTicks(7298) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 15, 12, 617, DateTimeKind.Local).AddTicks(7302), new DateTime(2025, 1, 20, 16, 15, 12, 617, DateTimeKind.Local).AddTicks(7303) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 15, 12, 617, DateTimeKind.Local).AddTicks(7307), new DateTime(2025, 1, 20, 16, 15, 12, 617, DateTimeKind.Local).AddTicks(7308) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 15, 12, 617, DateTimeKind.Local).AddTicks(7312), new DateTime(2025, 1, 20, 16, 15, 12, 617, DateTimeKind.Local).AddTicks(7313) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 15, 12, 617, DateTimeKind.Local).AddTicks(7316), new DateTime(2025, 1, 20, 16, 15, 12, 617, DateTimeKind.Local).AddTicks(7317) });
        }
    }
}
