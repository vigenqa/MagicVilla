using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class checkstate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreeatedDate",
                value: new DateTime(2024, 4, 5, 14, 55, 50, 569, DateTimeKind.Local).AddTicks(9983));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreeatedDate",
                value: new DateTime(2024, 4, 5, 14, 55, 50, 569, DateTimeKind.Local).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreeatedDate",
                value: new DateTime(2024, 4, 5, 14, 55, 50, 569, DateTimeKind.Local).AddTicks(9999));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreeatedDate",
                value: new DateTime(2024, 4, 5, 14, 55, 50, 570, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreeatedDate",
                value: new DateTime(2024, 4, 5, 14, 55, 50, 570, DateTimeKind.Local).AddTicks(2));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreeatedDate",
                value: new DateTime(2024, 4, 5, 14, 54, 18, 407, DateTimeKind.Local).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreeatedDate",
                value: new DateTime(2024, 4, 5, 14, 54, 18, 407, DateTimeKind.Local).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreeatedDate",
                value: new DateTime(2024, 4, 5, 14, 54, 18, 407, DateTimeKind.Local).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreeatedDate",
                value: new DateTime(2024, 4, 5, 14, 54, 18, 407, DateTimeKind.Local).AddTicks(4401));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreeatedDate",
                value: new DateTime(2024, 4, 5, 14, 54, 18, 407, DateTimeKind.Local).AddTicks(4402));
        }
    }
}
