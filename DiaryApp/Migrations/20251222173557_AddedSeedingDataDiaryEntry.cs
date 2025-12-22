using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedingDataDiaryEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Content", "Created", "Title" },
                values: new object[,]
                {
                    { 1, "Went hiking with Joe!", new DateTime(2025, 12, 23, 4, 35, 57, 467, DateTimeKind.Local).AddTicks(2323), "Went hiking" },
                    { 2, "Made Tea with Angela!", new DateTime(2025, 12, 23, 4, 35, 57, 467, DateTimeKind.Local).AddTicks(2499), "Made Tea" },
                    { 3, "Went diving with Christie!", new DateTime(2025, 12, 23, 4, 35, 57, 467, DateTimeKind.Local).AddTicks(2503), "Went diving" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
