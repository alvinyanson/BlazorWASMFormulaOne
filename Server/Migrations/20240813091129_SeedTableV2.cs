using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FormulaOne.Server.Migrations
{
    /// <inheritdoc />
    public partial class SeedTableV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "Id", "Name", "RacingNb", "Team" },
                values: new object[,]
                {
                    { 6, "Michael Schumacher", "1", "Ferrari" },
                    { 7, "Felipe Massa", "6", "Ferrari" },
                    { 8, "Kimi Räikkönen", "7", "Ferrari" },
                    { 9, "Fernando Alonso", "14", "Ferrari" },
                    { 10, "Sebastian Vettel", "5", "Ferrari" },
                    { 11, "Charles Leclerc", "16", "Ferrari" },
                    { 12, "Carlos Sainz", "55", "Ferrari" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Drivers",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
