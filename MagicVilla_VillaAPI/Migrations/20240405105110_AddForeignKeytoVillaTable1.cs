using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeytoVillaTable1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreeatedDate",
                value: new DateTime(2024, 4, 5, 14, 51, 10, 868, DateTimeKind.Local).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreeatedDate",
                value: new DateTime(2024, 4, 5, 14, 51, 10, 868, DateTimeKind.Local).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreeatedDate",
                value: new DateTime(2024, 4, 5, 14, 51, 10, 868, DateTimeKind.Local).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreeatedDate",
                value: new DateTime(2024, 4, 5, 14, 51, 10, 868, DateTimeKind.Local).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreeatedDate",
                value: new DateTime(2024, 4, 5, 14, 51, 10, 868, DateTimeKind.Local).AddTicks(4387));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreeatedDate",
                value: new DateTime(2024, 4, 5, 14, 28, 27, 606, DateTimeKind.Local).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreeatedDate",
                value: new DateTime(2024, 4, 5, 14, 28, 27, 606, DateTimeKind.Local).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreeatedDate",
                value: new DateTime(2024, 4, 5, 14, 28, 27, 606, DateTimeKind.Local).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreeatedDate",
                value: new DateTime(2024, 4, 5, 14, 28, 27, 606, DateTimeKind.Local).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreeatedDate",
                value: new DateTime(2024, 4, 5, 14, 28, 27, 606, DateTimeKind.Local).AddTicks(1508));
        }
    }
}
