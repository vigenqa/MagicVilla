using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class filldataInTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreeatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2024, 2, 16, 19, 45, 57, 861, DateTimeKind.Local).AddTicks(1490), "Villa Details", "https://i.pinimg.com/736x/c9/63/7a/c9637a6a3716d65de5b91c38fbbd3f89.jpg", "Rayal Villa", 5, 200.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Private pool, beach access, BBQ area", new DateTime(2024, 2, 16, 19, 45, 57, 861, DateTimeKind.Local).AddTicks(1506), "Luxury beachfront villa with stunning ocean views", "https://www.beachhousenassau.com/wp-content/uploads/2018/10/Beach_House_Nassau_Ocean_View_Room1.jpg", "Ocean View Paradise", 8, 500.0, 1200, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Fireplace, hiking trails nearby, scenic views", new DateTime(2024, 2, 16, 19, 45, 57, 861, DateTimeKind.Local).AddTicks(1508), "Cozy cabin nestled in the mountains, perfect for nature lovers", "https://www.cabinsusa.com/uploads/images/units/828/828_1438040497_7935.jpg", "Mountain Retreat Cabin", 4, 150.0, 800, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Rooftop terrace, modern furnishings, city skyline views", new DateTime(2024, 2, 16, 19, 45, 57, 861, DateTimeKind.Local).AddTicks(1509), "Chic loft apartment in the heart of the city", "https://www.apartments.com/images/default-source/default-album/hero-photos/primary-hero-images/apartment-exterior-02-003.jpg?sfvrsn=f7bbd086_0", "Urban Loft", 2, 300.0, 700, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Wrap-around porch, garden, farm-to-table dining", new DateTime(2024, 2, 16, 19, 45, 57, 861, DateTimeKind.Local).AddTicks(1511), "Quaint farmhouse surrounded by rolling hills and fields", "https://media.istockphoto.com/photos/old-rustic-farmhouse-picture-id157708876?k=20&m=157708876&s=612x612&w=0&h=iW5YlBeuE0rM40voaLtwQh-QBebZZD3igDn7AATi6Wg=", "Rustic Farmhouse", 6, 250.0, 1000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
