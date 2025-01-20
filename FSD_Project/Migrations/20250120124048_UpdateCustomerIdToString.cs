using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCustomerIdToString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Customer_CustomerId",
                table: "Reservation");

            migrationBuilder.DropIndex(
                name: "IX_Reservation_CustomerId",
                table: "Reservation");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerId",
                table: "Reservation",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId1",
                table: "Reservation",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb9ec7c7-be85-4ee9-ba0c-a5684e49aff9", "AQAAAAIAAYagAAAAECkCHbrSdxn3W/Cmc14YAEpjEX5tzj9BI6euj495MdbQLAUKoY9GN5rd8nO70BC6Zw==", "e0bd51f7-b995-474e-9908-3f5e1ba5fc40" });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 20, 40, 47, 731, DateTimeKind.Local).AddTicks(3668), new DateTime(2025, 1, 20, 20, 40, 47, 731, DateTimeKind.Local).AddTicks(3677) });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 20, 40, 47, 731, DateTimeKind.Local).AddTicks(3679), new DateTime(2025, 1, 20, 20, 40, 47, 731, DateTimeKind.Local).AddTicks(3679) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 20, 40, 47, 731, DateTimeKind.Local).AddTicks(3804), new DateTime(2025, 1, 20, 20, 40, 47, 731, DateTimeKind.Local).AddTicks(3804) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 20, 40, 47, 731, DateTimeKind.Local).AddTicks(3806), new DateTime(2025, 1, 20, 20, 40, 47, 731, DateTimeKind.Local).AddTicks(3806) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CustomerId", "CustomerId1", "DateCreated", "DateUpdated", "ReservedDateTime" },
                values: new object[] { "1", null, new DateTime(2025, 1, 20, 20, 40, 47, 731, DateTimeKind.Local).AddTicks(3862), new DateTime(2025, 1, 20, 20, 40, 47, 731, DateTimeKind.Local).AddTicks(3863), new DateTime(2025, 1, 20, 20, 40, 47, 731, DateTimeKind.Local).AddTicks(3861) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CustomerId", "CustomerId1", "DateCreated", "DateUpdated", "ReservedDateTime" },
                values: new object[] { "2", null, new DateTime(2025, 1, 20, 20, 40, 47, 731, DateTimeKind.Local).AddTicks(3865), new DateTime(2025, 1, 20, 20, 40, 47, 731, DateTimeKind.Local).AddTicks(3865), new DateTime(2025, 1, 20, 20, 40, 47, 731, DateTimeKind.Local).AddTicks(3864) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 20, 40, 47, 731, DateTimeKind.Local).AddTicks(3922), new DateTime(2025, 1, 20, 20, 40, 47, 731, DateTimeKind.Local).AddTicks(3922) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 20, 40, 47, 731, DateTimeKind.Local).AddTicks(3924), new DateTime(2025, 1, 20, 20, 40, 47, 731, DateTimeKind.Local).AddTicks(3925) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 20, 40, 47, 731, DateTimeKind.Local).AddTicks(3977), new DateTime(2025, 1, 20, 20, 40, 47, 731, DateTimeKind.Local).AddTicks(3977) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 20, 40, 47, 731, DateTimeKind.Local).AddTicks(3978), new DateTime(2025, 1, 20, 20, 40, 47, 731, DateTimeKind.Local).AddTicks(3979) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 20, 40, 47, 731, DateTimeKind.Local).AddTicks(3980), new DateTime(2025, 1, 20, 20, 40, 47, 731, DateTimeKind.Local).AddTicks(3980) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 20, 40, 47, 731, DateTimeKind.Local).AddTicks(3981), new DateTime(2025, 1, 20, 20, 40, 47, 731, DateTimeKind.Local).AddTicks(3981) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 20, 40, 47, 731, DateTimeKind.Local).AddTicks(3982), new DateTime(2025, 1, 20, 20, 40, 47, 731, DateTimeKind.Local).AddTicks(3983) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 20, 40, 47, 731, DateTimeKind.Local).AddTicks(3984), new DateTime(2025, 1, 20, 20, 40, 47, 731, DateTimeKind.Local).AddTicks(3984) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 20, 40, 47, 731, DateTimeKind.Local).AddTicks(3985), new DateTime(2025, 1, 20, 20, 40, 47, 731, DateTimeKind.Local).AddTicks(3985) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 20, 40, 47, 731, DateTimeKind.Local).AddTicks(3986), new DateTime(2025, 1, 20, 20, 40, 47, 731, DateTimeKind.Local).AddTicks(3987) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 20, 40, 47, 731, DateTimeKind.Local).AddTicks(3988), new DateTime(2025, 1, 20, 20, 40, 47, 731, DateTimeKind.Local).AddTicks(3988) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 20, 40, 47, 731, DateTimeKind.Local).AddTicks(3989), new DateTime(2025, 1, 20, 20, 40, 47, 731, DateTimeKind.Local).AddTicks(3990) });

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_CustomerId1",
                table: "Reservation",
                column: "CustomerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Customer_CustomerId1",
                table: "Reservation",
                column: "CustomerId1",
                principalTable: "Customer",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Customer_CustomerId1",
                table: "Reservation");

            migrationBuilder.DropIndex(
                name: "IX_Reservation_CustomerId1",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "CustomerId1",
                table: "Reservation");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Reservation",
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
                values: new object[] { "f6c498b8-f3f0-489e-a5d3-5492d20568b8", "AQAAAAIAAYagAAAAEKbb1lWtDyET4nqMJRdcA43i4xassS9gAxroxHO3pXk8icsT8QGixHbDqpWJaP4Jlg==", "212d6afc-771f-41f2-b023-c543d304642c" });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 20, 13, 34, 296, DateTimeKind.Local).AddTicks(314), new DateTime(2025, 1, 20, 20, 13, 34, 296, DateTimeKind.Local).AddTicks(323) });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 20, 13, 34, 296, DateTimeKind.Local).AddTicks(325), new DateTime(2025, 1, 20, 20, 13, 34, 296, DateTimeKind.Local).AddTicks(325) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 20, 13, 34, 296, DateTimeKind.Local).AddTicks(446), new DateTime(2025, 1, 20, 20, 13, 34, 296, DateTimeKind.Local).AddTicks(447) });

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 20, 13, 34, 296, DateTimeKind.Local).AddTicks(448), new DateTime(2025, 1, 20, 20, 13, 34, 296, DateTimeKind.Local).AddTicks(448) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CustomerId", "DateCreated", "DateUpdated", "ReservedDateTime" },
                values: new object[] { 1, new DateTime(2025, 1, 20, 20, 13, 34, 296, DateTimeKind.Local).AddTicks(502), new DateTime(2025, 1, 20, 20, 13, 34, 296, DateTimeKind.Local).AddTicks(503), new DateTime(2025, 1, 20, 20, 13, 34, 296, DateTimeKind.Local).AddTicks(501) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CustomerId", "DateCreated", "DateUpdated", "ReservedDateTime" },
                values: new object[] { 2, new DateTime(2025, 1, 20, 20, 13, 34, 296, DateTimeKind.Local).AddTicks(505), new DateTime(2025, 1, 20, 20, 13, 34, 296, DateTimeKind.Local).AddTicks(506), new DateTime(2025, 1, 20, 20, 13, 34, 296, DateTimeKind.Local).AddTicks(504) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 20, 13, 34, 296, DateTimeKind.Local).AddTicks(574), new DateTime(2025, 1, 20, 20, 13, 34, 296, DateTimeKind.Local).AddTicks(574) });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 20, 13, 34, 296, DateTimeKind.Local).AddTicks(576), new DateTime(2025, 1, 20, 20, 13, 34, 296, DateTimeKind.Local).AddTicks(576) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 20, 13, 34, 296, DateTimeKind.Local).AddTicks(627), new DateTime(2025, 1, 20, 20, 13, 34, 296, DateTimeKind.Local).AddTicks(628) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 20, 13, 34, 296, DateTimeKind.Local).AddTicks(629), new DateTime(2025, 1, 20, 20, 13, 34, 296, DateTimeKind.Local).AddTicks(629) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 20, 13, 34, 296, DateTimeKind.Local).AddTicks(630), new DateTime(2025, 1, 20, 20, 13, 34, 296, DateTimeKind.Local).AddTicks(631) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 20, 13, 34, 296, DateTimeKind.Local).AddTicks(632), new DateTime(2025, 1, 20, 20, 13, 34, 296, DateTimeKind.Local).AddTicks(632) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 20, 13, 34, 296, DateTimeKind.Local).AddTicks(633), new DateTime(2025, 1, 20, 20, 13, 34, 296, DateTimeKind.Local).AddTicks(633) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 20, 13, 34, 296, DateTimeKind.Local).AddTicks(634), new DateTime(2025, 1, 20, 20, 13, 34, 296, DateTimeKind.Local).AddTicks(635) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 20, 13, 34, 296, DateTimeKind.Local).AddTicks(636), new DateTime(2025, 1, 20, 20, 13, 34, 296, DateTimeKind.Local).AddTicks(636) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 20, 13, 34, 296, DateTimeKind.Local).AddTicks(637), new DateTime(2025, 1, 20, 20, 13, 34, 296, DateTimeKind.Local).AddTicks(637) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 20, 13, 34, 296, DateTimeKind.Local).AddTicks(638), new DateTime(2025, 1, 20, 20, 13, 34, 296, DateTimeKind.Local).AddTicks(638) });

            migrationBuilder.UpdateData(
                table: "Table",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 20, 20, 13, 34, 296, DateTimeKind.Local).AddTicks(639), new DateTime(2025, 1, 20, 20, 13, 34, 296, DateTimeKind.Local).AddTicks(640) });

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_CustomerId",
                table: "Reservation",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Customer_CustomerId",
                table: "Reservation",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id");
        }
    }
}
