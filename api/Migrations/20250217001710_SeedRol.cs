using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class SeedRol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7809a488-aa95-48a0-91d5-8157ca09ff5e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b564ed2d-db56-4bd3-a0f0-e108bdc45f7d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7530120b-43f3-40c0-b818-2fd711e2e9d5", null, "User", "USER" },
                    { "93bd3c7e-c8a2-4d9b-8977-c7474ddd1440", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7530120b-43f3-40c0-b818-2fd711e2e9d5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93bd3c7e-c8a2-4d9b-8977-c7474ddd1440");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7809a488-aa95-48a0-91d5-8157ca09ff5e", null, "User", "USER" },
                    { "b564ed2d-db56-4bd3-a0f0-e108bdc45f7d", null, "Admin", "ADMIN" }
                });
        }
    }
}
