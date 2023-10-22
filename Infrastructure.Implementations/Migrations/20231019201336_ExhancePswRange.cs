using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Implementations.Migrations
{
    /// <inheritdoc />
    public partial class ExhancePswRange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PasswordSalt",
                schema: "auth",
                table: "users",
                type: "varchar(256)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(64)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PasswordSalt",
                schema: "auth",
                table: "users",
                type: "varchar(64)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(256)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
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
                value: new DateTime(2023, 10, 17, 19, 50, 11, 956, DateTimeKind.Utc).AddTicks(4798));

            migrationBuilder.UpdateData(
                schema: "auth",
                table: "roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2023, 10, 17, 19, 50, 11, 956, DateTimeKind.Utc).AddTicks(4803));

            migrationBuilder.UpdateData(
                schema: "auth",
                table: "roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2023, 10, 17, 19, 50, 11, 956, DateTimeKind.Utc).AddTicks(4804));
        }
    }
}
