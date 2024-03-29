using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class RenameVillaNumbersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_villaNumbers",
                table: "villaNumbers");

            migrationBuilder.RenameTable(
                name: "villaNumbers",
                newName: "VillaNumbers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VillaNumbers",
                table: "VillaNumbers",
                column: "VillaNo");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreeatedDate",
                value: new DateTime(2024, 3, 29, 14, 31, 16, 973, DateTimeKind.Local).AddTicks(4013));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreeatedDate",
                value: new DateTime(2024, 3, 29, 14, 31, 16, 973, DateTimeKind.Local).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreeatedDate",
                value: new DateTime(2024, 3, 29, 14, 31, 16, 973, DateTimeKind.Local).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreeatedDate",
                value: new DateTime(2024, 3, 29, 14, 31, 16, 973, DateTimeKind.Local).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreeatedDate",
                value: new DateTime(2024, 3, 29, 14, 31, 16, 973, DateTimeKind.Local).AddTicks(4030));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VillaNumbers",
                table: "VillaNumbers");

            migrationBuilder.RenameTable(
                name: "VillaNumbers",
                newName: "villaNumbers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_villaNumbers",
                table: "villaNumbers",
                column: "VillaNo");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreeatedDate",
                value: new DateTime(2024, 3, 29, 14, 19, 32, 826, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreeatedDate",
                value: new DateTime(2024, 3, 29, 14, 19, 32, 826, DateTimeKind.Local).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreeatedDate",
                value: new DateTime(2024, 3, 29, 14, 19, 32, 826, DateTimeKind.Local).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreeatedDate",
                value: new DateTime(2024, 3, 29, 14, 19, 32, 826, DateTimeKind.Local).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreeatedDate",
                value: new DateTime(2024, 3, 29, 14, 19, 32, 826, DateTimeKind.Local).AddTicks(1550));
        }
    }
}
