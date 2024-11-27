using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FSD_Project.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "contactNumber",
                table: "Staff",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "contactNumber",
                table: "Customer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Branch",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Location", "Name", "UpdatedBy", "contactNumber" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 27, 20, 28, 33, 256, DateTimeKind.Local).AddTicks(2653), new DateTime(2024, 11, 27, 20, 28, 33, 256, DateTimeKind.Local).AddTicks(2664), "Woodlands", "Branch 1", "System", 61234567 },
                    { 2, "System", new DateTime(2024, 11, 27, 20, 28, 33, 256, DateTimeKind.Local).AddTicks(2666), new DateTime(2024, 11, 27, 20, 28, 33, 256, DateTimeKind.Local).AddTicks(2666), "Punggol", "Branch 2", "System", 61234566 }
                });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Gender", "Name", "UpdatedBy", "contactNumber" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 27, 20, 28, 33, 256, DateTimeKind.Local).AddTicks(2843), new DateTime(2024, 11, 27, 20, 28, 33, 256, DateTimeKind.Local).AddTicks(2843), "Male", "David Lee", "System", 91234567 },
                    { 2, "System", new DateTime(2024, 11, 27, 20, 28, 33, 256, DateTimeKind.Local).AddTicks(2845), new DateTime(2024, 11, 27, 20, 28, 33, 256, DateTimeKind.Local).AddTicks(2845), "Male", "John Matthew", "System", 91234566 }
                });

            migrationBuilder.InsertData(
                table: "Reservation",
                columns: new[] { "Id", "BranchId", "CreatedBy", "CustomerId", "DateCreated", "DateUpdated", "ReservedDateTime", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, "System", 1, new DateTime(2024, 11, 27, 20, 28, 33, 256, DateTimeKind.Local).AddTicks(2897), new DateTime(2024, 11, 27, 20, 28, 33, 256, DateTimeKind.Local).AddTicks(2897), new DateTime(2024, 11, 27, 20, 28, 33, 256, DateTimeKind.Local).AddTicks(2896), "System" },
                    { 2, 1, "System", 2, new DateTime(2024, 11, 27, 20, 28, 33, 256, DateTimeKind.Local).AddTicks(2899), new DateTime(2024, 11, 27, 20, 28, 33, 256, DateTimeKind.Local).AddTicks(2899), new DateTime(2024, 11, 27, 20, 28, 33, 256, DateTimeKind.Local).AddTicks(2898), "System" }
                });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "Id", "BranchId", "CreatedBy", "DateCreated", "DateUpdated", "Gender", "Name", "UpdatedBy", "contactNumber" },
                values: new object[,]
                {
                    { 1, 1, "System", new DateTime(2024, 11, 27, 20, 28, 33, 256, DateTimeKind.Local).AddTicks(2948), new DateTime(2024, 11, 27, 20, 28, 33, 256, DateTimeKind.Local).AddTicks(2948), "Male", "Gordon Sim", "System", 97581578 },
                    { 2, 1, "System", new DateTime(2024, 11, 27, 20, 28, 33, 256, DateTimeKind.Local).AddTicks(2950), new DateTime(2024, 11, 27, 20, 28, 33, 256, DateTimeKind.Local).AddTicks(2950), "Female", "En Xuan", "System", 98886482 }
                });

            migrationBuilder.InsertData(
                table: "Table",
                columns: new[] { "Id", "BranchId", "Capacity", "CreatedBy", "DateCreated", "DateUpdated", "Status", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, 5, "System", new DateTime(2024, 11, 27, 20, 28, 33, 256, DateTimeKind.Local).AddTicks(3015), new DateTime(2024, 11, 27, 20, 28, 33, 256, DateTimeKind.Local).AddTicks(3016), true, "System" },
                    { 2, 1, 5, "System", new DateTime(2024, 11, 27, 20, 28, 33, 256, DateTimeKind.Local).AddTicks(3017), new DateTime(2024, 11, 27, 20, 28, 33, 256, DateTimeKind.Local).AddTicks(3017), true, "System" },
                    { 3, 1, 5, "System", new DateTime(2024, 11, 27, 20, 28, 33, 256, DateTimeKind.Local).AddTicks(3018), new DateTime(2024, 11, 27, 20, 28, 33, 256, DateTimeKind.Local).AddTicks(3019), true, "System" },
                    { 4, 1, 5, "System", new DateTime(2024, 11, 27, 20, 28, 33, 256, DateTimeKind.Local).AddTicks(3020), new DateTime(2024, 11, 27, 20, 28, 33, 256, DateTimeKind.Local).AddTicks(3020), true, "System" },
                    { 5, 1, 5, "System", new DateTime(2024, 11, 27, 20, 28, 33, 256, DateTimeKind.Local).AddTicks(3021), new DateTime(2024, 11, 27, 20, 28, 33, 256, DateTimeKind.Local).AddTicks(3021), true, "System" },
                    { 6, 1, 5, "System", new DateTime(2024, 11, 27, 20, 28, 33, 256, DateTimeKind.Local).AddTicks(3022), new DateTime(2024, 11, 27, 20, 28, 33, 256, DateTimeKind.Local).AddTicks(3022), true, "System" },
                    { 7, 1, 5, "System", new DateTime(2024, 11, 27, 20, 28, 33, 256, DateTimeKind.Local).AddTicks(3023), new DateTime(2024, 11, 27, 20, 28, 33, 256, DateTimeKind.Local).AddTicks(3024), true, "System" },
                    { 8, 1, 5, "System", new DateTime(2024, 11, 27, 20, 28, 33, 256, DateTimeKind.Local).AddTicks(3025), new DateTime(2024, 11, 27, 20, 28, 33, 256, DateTimeKind.Local).AddTicks(3025), true, "System" },
                    { 9, 1, 5, "System", new DateTime(2024, 11, 27, 20, 28, 33, 256, DateTimeKind.Local).AddTicks(3026), new DateTime(2024, 11, 27, 20, 28, 33, 256, DateTimeKind.Local).AddTicks(3026), true, "System" },
                    { 10, 1, 5, "System", new DateTime(2024, 11, 27, 20, 28, 33, 256, DateTimeKind.Local).AddTicks(3027), new DateTime(2024, 11, 27, 20, 28, 33, 256, DateTimeKind.Local).AddTicks(3027), true, "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "contactNumber",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "contactNumber",
                table: "Customer");
        }
    }
}
