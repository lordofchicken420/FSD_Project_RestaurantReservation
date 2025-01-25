using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FSD_Project.Migrations
{
    /// <inheritdoc />
    public partial class AddRating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Score = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReservationId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReservationId1 = table.Column<int>(type: "int", nullable: true),
                    CustomerId1 = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_Customer_CustomerId1",
                        column: x => x.CustomerId1,
                        principalTable: "Customer",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Ratings_Reservation_ReservationId1",
                        column: x => x.ReservationId1,
                        principalTable: "Reservation",
                        principalColumn: "Id");
                });

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

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "Comments", "CreatedBy", "CustomerId", "CustomerId1", "DateCreated", "DateUpdated", "ReservationId", "ReservationId1", "Score", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "The Souvlaki's flavour was unlike anything I've ever had before!", "System", "1", null, new DateTime(2025, 1, 22, 10, 10, 51, 297, DateTimeKind.Local).AddTicks(8199), new DateTime(2025, 1, 22, 10, 10, 51, 297, DateTimeKind.Local).AddTicks(8225), "1", null, 5, "System" },
                    { 2, "The Baklava was the perfect way to end off this fantastic meal!", "System", "2", null, new DateTime(2025, 1, 22, 10, 10, 51, 297, DateTimeKind.Local).AddTicks(8228), new DateTime(2025, 1, 22, 10, 10, 51, 297, DateTimeKind.Local).AddTicks(8229), "2", null, 5, "System" }
                });

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
                name: "IX_Ratings_CustomerId1",
                table: "Ratings",
                column: "CustomerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_ReservationId1",
                table: "Ratings",
                column: "ReservationId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c2866d0-938e-4438-a3ad-20b047382cd5", "AQAAAAIAAYagAAAAECC1CBK/1o37DSX6GzqNwziKFfHoU/YdS3M83qiak1DlBgLnlLCFBS4Y/AQPZFK09A==", "3986992f-9852-41f2-89d0-ccee6b174b49" });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2011), new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2023) });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2027), new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2028) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2263), new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2263) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2267), new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2267) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "ReservedDateTime" },
                values: new object[] { new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2381), new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2382), new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2379) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "ReservedDateTime" },
                values: new object[] { new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2386), new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2386), new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2384) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2532), new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2533) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2537), new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2537) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2643), new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2644) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2647), new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2648) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2650), new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2651) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2653), new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2654) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2656), new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2657) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2659), new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2663), new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2664) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2667), new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2668) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2671), new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2672) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2674), new DateTime(2025, 1, 21, 10, 19, 16, 925, DateTimeKind.Local).AddTicks(2675) });
        }
    }
}
