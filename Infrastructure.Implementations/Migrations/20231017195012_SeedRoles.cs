using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Implementations.Migrations
{
    /// <inheritdoc />
    public partial class SeedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "auth",
                table: "roles",
                columns: new[] { "Id", "CreatedTime", "Type", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 17, 19, 50, 11, 956, DateTimeKind.Utc).AddTicks(4798), 1, null },
                    { 2, new DateTime(2023, 10, 17, 19, 50, 11, 956, DateTimeKind.Utc).AddTicks(4803), 2, null },
                    { 3, new DateTime(2023, 10, 17, 19, 50, 11, 956, DateTimeKind.Utc).AddTicks(4804), 3, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "auth",
                table: "roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "roles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "roles",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
