using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Implementations.Migrations
{
    /// <inheritdoc />
    public partial class EnhanceTokenRestrictions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "VerificationToken",
                schema: "auth",
                table: "users",
                type: "varchar(256)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(64)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ResetToken",
                schema: "auth",
                table: "users",
                type: "varchar(256)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(64)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "auth",
                table: "roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 10, 20, 19, 16, 7, 90, DateTimeKind.Utc).AddTicks(2011));

            migrationBuilder.UpdateData(
                schema: "auth",
                table: "roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 10, 20, 19, 16, 7, 90, DateTimeKind.Utc).AddTicks(2014));

            migrationBuilder.UpdateData(
                schema: "auth",
                table: "roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 10, 20, 19, 16, 7, 90, DateTimeKind.Utc).AddTicks(2015));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "VerificationToken",
                schema: "auth",
                table: "users",
                type: "varchar(64)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(256)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ResetToken",
                schema: "auth",
                table: "users",
                type: "varchar(64)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(256)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "auth",
                table: "roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2023, 10, 19, 20, 13, 36, 518, DateTimeKind.Utc).AddTicks(8574));

            migrationBuilder.UpdateData(
                schema: "auth",
                table: "roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 10, 19, 20, 13, 36, 518, DateTimeKind.Utc).AddTicks(8578));

            migrationBuilder.UpdateData(
                schema: "auth",
                table: "roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 10, 19, 20, 13, 36, 518, DateTimeKind.Utc).AddTicks(8580));
        }
    }
}
