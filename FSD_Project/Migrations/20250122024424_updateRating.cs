using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project.Migrations
{
    /// <inheritdoc />
    public partial class updateRating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Reservation_ReservationId1",
                table: "Ratings");

            migrationBuilder.DropIndex(
                name: "IX_Ratings_ReservationId1",
                table: "Ratings");

            migrationBuilder.DropColumn(
                name: "ReservationId1",
                table: "Ratings");

            migrationBuilder.AlterColumn<int>(
                name: "ReservationId",
                table: "Ratings",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a1a0a09-9bc9-4036-94be-4e452e201281", "AQAAAAIAAYagAAAAELK18WGOeP+RJd4tof7bH1tof4RoVH2XfPqpnCj5aGpirXEuB+hl82t0LRytVqnzsQ==", "33b60137-a2d6-437d-9180-6b0abef5adc9" });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 44, 23, 865, DateTimeKind.Local).AddTicks(9515), new DateTime(2025, 1, 22, 10, 44, 23, 865, DateTimeKind.Local).AddTicks(9526) });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 44, 23, 865, DateTimeKind.Local).AddTicks(9528), new DateTime(2025, 1, 22, 10, 44, 23, 865, DateTimeKind.Local).AddTicks(9528) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 44, 23, 865, DateTimeKind.Local).AddTicks(9678), new DateTime(2025, 1, 22, 10, 44, 23, 865, DateTimeKind.Local).AddTicks(9679) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 44, 23, 865, DateTimeKind.Local).AddTicks(9681), new DateTime(2025, 1, 22, 10, 44, 23, 865, DateTimeKind.Local).AddTicks(9681) });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ReservationId" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 44, 23, 909, DateTimeKind.Local).AddTicks(550), new DateTime(2025, 1, 22, 10, 44, 23, 909, DateTimeKind.Local).AddTicks(560), 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ReservationId" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 44, 23, 909, DateTimeKind.Local).AddTicks(562), new DateTime(2025, 1, 22, 10, 44, 23, 909, DateTimeKind.Local).AddTicks(563), 2 });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ReservedDateTime" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 44, 23, 865, DateTimeKind.Local).AddTicks(9741), new DateTime(2025, 1, 22, 10, 44, 23, 865, DateTimeKind.Local).AddTicks(9741), new DateTime(2025, 1, 22, 10, 44, 23, 865, DateTimeKind.Local).AddTicks(9739) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ReservedDateTime" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 44, 23, 865, DateTimeKind.Local).AddTicks(9743), new DateTime(2025, 1, 22, 10, 44, 23, 865, DateTimeKind.Local).AddTicks(9744), new DateTime(2025, 1, 22, 10, 44, 23, 865, DateTimeKind.Local).AddTicks(9743) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 44, 23, 865, DateTimeKind.Local).AddTicks(9803), new DateTime(2025, 1, 22, 10, 44, 23, 865, DateTimeKind.Local).AddTicks(9804) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 44, 23, 865, DateTimeKind.Local).AddTicks(9805), new DateTime(2025, 1, 22, 10, 44, 23, 865, DateTimeKind.Local).AddTicks(9806) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 44, 23, 865, DateTimeKind.Local).AddTicks(9962), new DateTime(2025, 1, 22, 10, 44, 23, 865, DateTimeKind.Local).AddTicks(9963) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 44, 23, 865, DateTimeKind.Local).AddTicks(9965), new DateTime(2025, 1, 22, 10, 44, 23, 865, DateTimeKind.Local).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 44, 23, 865, DateTimeKind.Local).AddTicks(9967), new DateTime(2025, 1, 22, 10, 44, 23, 865, DateTimeKind.Local).AddTicks(9967) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 44, 23, 865, DateTimeKind.Local).AddTicks(9968), new DateTime(2025, 1, 22, 10, 44, 23, 865, DateTimeKind.Local).AddTicks(9969) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 44, 23, 865, DateTimeKind.Local).AddTicks(9970), new DateTime(2025, 1, 22, 10, 44, 23, 865, DateTimeKind.Local).AddTicks(9970) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 44, 23, 865, DateTimeKind.Local).AddTicks(9972), new DateTime(2025, 1, 22, 10, 44, 23, 865, DateTimeKind.Local).AddTicks(9972) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 44, 23, 865, DateTimeKind.Local).AddTicks(9973), new DateTime(2025, 1, 22, 10, 44, 23, 865, DateTimeKind.Local).AddTicks(9974) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 44, 23, 865, DateTimeKind.Local).AddTicks(9975), new DateTime(2025, 1, 22, 10, 44, 23, 865, DateTimeKind.Local).AddTicks(9975) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 44, 23, 865, DateTimeKind.Local).AddTicks(9976), new DateTime(2025, 1, 22, 10, 44, 23, 865, DateTimeKind.Local).AddTicks(9977) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 44, 23, 865, DateTimeKind.Local).AddTicks(9978), new DateTime(2025, 1, 22, 10, 44, 23, 865, DateTimeKind.Local).AddTicks(9978) });

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_ReservationId",
                table: "Ratings",
                column: "ReservationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Reservation_ReservationId",
                table: "Ratings",
                column: "ReservationId",
                principalTable: "Reservation",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Reservation_ReservationId",
                table: "Ratings");

            migrationBuilder.DropIndex(
                name: "IX_Ratings_ReservationId",
                table: "Ratings");

            migrationBuilder.AlterColumn<string>(
                name: "ReservationId",
                table: "Ratings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReservationId1",
                table: "Ratings",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a591c7b-53db-4372-b4b9-3964c622dbaa", "AQAAAAIAAYagAAAAEAEgALRKSZgbe7UYfOGBT/lWdECOhOX1rI/4x6rK4NF/8doF7E5Y1deZbAMtA9jOdA==", "1a37127e-dce1-441b-92ae-4f9effe54215" });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 10, 51, 246, DateTimeKind.Local).AddTicks(5520), new DateTime(2025, 1, 22, 10, 10, 51, 246, DateTimeKind.Local).AddTicks(5532) });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 10, 51, 246, DateTimeKind.Local).AddTicks(5536), new DateTime(2025, 1, 22, 10, 10, 51, 246, DateTimeKind.Local).AddTicks(5537) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 10, 51, 246, DateTimeKind.Local).AddTicks(5737), new DateTime(2025, 1, 22, 10, 10, 51, 246, DateTimeKind.Local).AddTicks(5738) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 10, 51, 246, DateTimeKind.Local).AddTicks(5741), new DateTime(2025, 1, 22, 10, 10, 51, 246, DateTimeKind.Local).AddTicks(5742) });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ReservationId", "ReservationId1" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 10, 51, 297, DateTimeKind.Local).AddTicks(8199), new DateTime(2025, 1, 22, 10, 10, 51, 297, DateTimeKind.Local).AddTicks(8225), "1", null });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ReservationId", "ReservationId1" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 10, 51, 297, DateTimeKind.Local).AddTicks(8228), new DateTime(2025, 1, 22, 10, 10, 51, 297, DateTimeKind.Local).AddTicks(8229), "2", null });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ReservedDateTime" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 10, 51, 246, DateTimeKind.Local).AddTicks(5824), new DateTime(2025, 1, 22, 10, 10, 51, 246, DateTimeKind.Local).AddTicks(5825), new DateTime(2025, 1, 22, 10, 10, 51, 246, DateTimeKind.Local).AddTicks(5822) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ReservedDateTime" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 10, 51, 246, DateTimeKind.Local).AddTicks(5828), new DateTime(2025, 1, 22, 10, 10, 51, 246, DateTimeKind.Local).AddTicks(5828), new DateTime(2025, 1, 22, 10, 10, 51, 246, DateTimeKind.Local).AddTicks(5827) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 10, 51, 246, DateTimeKind.Local).AddTicks(5974), new DateTime(2025, 1, 22, 10, 10, 51, 246, DateTimeKind.Local).AddTicks(5975) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 10, 51, 246, DateTimeKind.Local).AddTicks(5977), new DateTime(2025, 1, 22, 10, 10, 51, 246, DateTimeKind.Local).AddTicks(5978) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 10, 51, 246, DateTimeKind.Local).AddTicks(6081), new DateTime(2025, 1, 22, 10, 10, 51, 246, DateTimeKind.Local).AddTicks(6082) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 10, 51, 246, DateTimeKind.Local).AddTicks(6084), new DateTime(2025, 1, 22, 10, 10, 51, 246, DateTimeKind.Local).AddTicks(6085) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 10, 51, 246, DateTimeKind.Local).AddTicks(6087), new DateTime(2025, 1, 22, 10, 10, 51, 246, DateTimeKind.Local).AddTicks(6088) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 10, 51, 246, DateTimeKind.Local).AddTicks(6090), new DateTime(2025, 1, 22, 10, 10, 51, 246, DateTimeKind.Local).AddTicks(6090) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 10, 51, 246, DateTimeKind.Local).AddTicks(6092), new DateTime(2025, 1, 22, 10, 10, 51, 246, DateTimeKind.Local).AddTicks(6093) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 10, 51, 246, DateTimeKind.Local).AddTicks(6095), new DateTime(2025, 1, 22, 10, 10, 51, 246, DateTimeKind.Local).AddTicks(6095) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 10, 51, 246, DateTimeKind.Local).AddTicks(6097), new DateTime(2025, 1, 22, 10, 10, 51, 246, DateTimeKind.Local).AddTicks(6098) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 10, 51, 246, DateTimeKind.Local).AddTicks(6100), new DateTime(2025, 1, 22, 10, 10, 51, 246, DateTimeKind.Local).AddTicks(6100) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 10, 51, 246, DateTimeKind.Local).AddTicks(6102), new DateTime(2025, 1, 22, 10, 10, 51, 246, DateTimeKind.Local).AddTicks(6103) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 22, 10, 10, 51, 246, DateTimeKind.Local).AddTicks(6105), new DateTime(2025, 1, 22, 10, 10, 51, 246, DateTimeKind.Local).AddTicks(6105) });

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_ReservationId1",
                table: "Ratings",
                column: "ReservationId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Reservation_ReservationId1",
                table: "Ratings",
                column: "ReservationId1",
                principalTable: "Reservation",
                principalColumn: "Id");
        }
    }
}
