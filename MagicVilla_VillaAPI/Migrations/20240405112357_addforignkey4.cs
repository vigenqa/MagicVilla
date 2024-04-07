using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class addforignkey4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreeatedDate",
                value: new DateTime(2024, 4, 5, 15, 23, 57, 124, DateTimeKind.Local).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreeatedDate",
                value: new DateTime(2024, 4, 5, 15, 23, 57, 124, DateTimeKind.Local).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreeatedDate",
                value: new DateTime(2024, 4, 5, 15, 23, 57, 124, DateTimeKind.Local).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreeatedDate",
                value: new DateTime(2024, 4, 5, 15, 23, 57, 124, DateTimeKind.Local).AddTicks(7374));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreeatedDate",
                value: new DateTime(2024, 4, 5, 15, 23, 57, 124, DateTimeKind.Local).AddTicks(7375));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreeatedDate",
                value: new DateTime(2024, 4, 5, 15, 8, 30, 38, DateTimeKind.Local).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreeatedDate",
                value: new DateTime(2024, 4, 5, 15, 8, 30, 38, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreeatedDate",
                value: new DateTime(2024, 4, 5, 15, 8, 30, 38, DateTimeKind.Local).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreeatedDate",
                value: new DateTime(2024, 4, 5, 15, 8, 30, 38, DateTimeKind.Local).AddTicks(1023));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreeatedDate",
                value: new DateTime(2024, 4, 5, 15, 8, 30, 38, DateTimeKind.Local).AddTicks(1025));
        }
    }
}
