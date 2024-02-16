using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Implementations.Migrations
{
    /// <inheritdoc />
    public partial class UserInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "Age",
                schema: "auth",
                table: "users",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<string>(
                name: "Avatar",
                schema: "auth",
                table: "users",
                type: "varchar(256)",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(684));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(689));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(690));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(691));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(692));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(693));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(694));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(695));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(696));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(696));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(697));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(698));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(699));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(699));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(700));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(701));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(701));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(702));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(703));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(704));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(705));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(705));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(707));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(708));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(708));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(709));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(709));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(710));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(711));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(712));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(712));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(713));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(714));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(715));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(715));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(716));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(717));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(718));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(718));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(719));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(720));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(721));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(721));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(722));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(724));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(725));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(726));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(727));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(727));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(728));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(728));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(729));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(730));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(730));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(731));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(732));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(732));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(733));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(734));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(734));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(735));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(735));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(736));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(737));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(738));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(740));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(740));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(741));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(742));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(742));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(743));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(744));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(745));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(745));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(746));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(747));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(747));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(749));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(750));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(751));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(751));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(752));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(753));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(753));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(754));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(754));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(755));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(756));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(756));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(757));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(758));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(758));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(759));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(759));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(760));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(761));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(761));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(762));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(763));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(763));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(764));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(765));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(765));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(766));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(767));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(767));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(768));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(769));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(769));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(770));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(770));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(771));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(772));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(772));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(773));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(774));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(774));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(775));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(776));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(776));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(777));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(777));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(778));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(779));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(779));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(780));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(781));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(781));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(782));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(783));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(783));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(784));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(785));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(785));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(786));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(787));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(787));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(788));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(788));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(789));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(790));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(791));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(792));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(793));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(794));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(794));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(795));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(796));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(796));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(797));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(798));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(798));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(800));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(800));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(801));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(802));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(802));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(803));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(803));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(804));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(805));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(805));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(806));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(807));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(807));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(808));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(809));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(809));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(810));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(811));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(811));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(812));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(812));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(813));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(814));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(814));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(815));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(816));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(816));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(817));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(818));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(818));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(819));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(820));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(820));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(821));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(822));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(822));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(823));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(824));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(824));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(825));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(826));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(826));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(827));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(828));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(828));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(829));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(830));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(830));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(831));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(832));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(833));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(833));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(835));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(835));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(836));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(837));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(837));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(838));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(839));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(840));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(840));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(841));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(842));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(842));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(843));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(844));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(844));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 224,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(845));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 225,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(846));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 226,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(846));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 227,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(847));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 228,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(848));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 229,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(848));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(849));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 231,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(850));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 232,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(851));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 233,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(851));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 234,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(852));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 235,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(853));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 236,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(853));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 237,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(854));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 238,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(855));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 239,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(855));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 240,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(856));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 241,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(857));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 242,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(857));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 243,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 357, DateTimeKind.Utc).AddTicks(858));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "language_levels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 355, DateTimeKind.Utc).AddTicks(8867));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "language_levels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 355, DateTimeKind.Utc).AddTicks(8870));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "language_levels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 355, DateTimeKind.Utc).AddTicks(8872));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "language_levels",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 355, DateTimeKind.Utc).AddTicks(8873));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "language_levels",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 355, DateTimeKind.Utc).AddTicks(8875));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "language_levels",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 355, DateTimeKind.Utc).AddTicks(8877));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "language_levels",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 355, DateTimeKind.Utc).AddTicks(8879));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "language_levels",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 355, DateTimeKind.Utc).AddTicks(8881));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(4710));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(4796));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(4819));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(4838));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(4856));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(4880));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(4894));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(4912));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(4929));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(4947));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(4967));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(4985));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5001));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5017));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5033));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5050));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5067));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5085));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5101));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5119));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5135));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5150));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5166));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5185));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5201));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5217));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5233));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5248));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5265));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5281));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5295));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5324));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5339));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5360));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5376));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5390));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5407));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5423));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5438));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5455));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5469));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5486));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5501));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5516));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5532));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5549));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5563));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5580));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5594));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5610));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5624));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5640));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5655));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5673));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5696));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5711));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5728));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5742));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5758));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5773));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5789));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5805));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5820));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5837));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5854));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5882));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5898));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5912));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5928));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5944));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5960));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5974));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(5990));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6005));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6022));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6038));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6054));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6070));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6087));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6101));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6117));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6133));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6149));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6164));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6179));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6193));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6209));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6225));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6239));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6253));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6270));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6286));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6302));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6318));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6333));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6350));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6365));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6382));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6397));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6411));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6428));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6444));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6461));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6476));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6492));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6520));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6536));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6551));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6567));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6581));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6596));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6611));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6625));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6641));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6657));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6673));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6688));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6704));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6736));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6751));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6767));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6782));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6797));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6812));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6828));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6845));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6861));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6878));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6896));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6914));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6930));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6945));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6961));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(6989));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7005));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7020));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7039));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7055));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7072));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7088));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7103));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7119));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7135));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7150));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7166));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7182));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7196));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7212));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7227));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7243));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7258));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7272));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7287));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7302));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7318));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7333));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7349));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7364));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7380));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7397));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7413));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7428));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7443));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7457));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7473));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7489));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7506));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7522));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7537));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7553));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7570));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7601));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7616));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7632));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7646));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7661));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7675));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7693));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7711));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7729));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7745));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7760));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7777));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7793));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7810));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7826));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7843));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7858));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7873));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7890));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7905));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7921));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7936));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7953));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7971));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(7986));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8002));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8018));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8035));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8051));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8066));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8081));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8096));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8111));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8126));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8141));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8158));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8174));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8191));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8206));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8235));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8252));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8269));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8285));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8301));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8318));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8333));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8350));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8366));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8383));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8398));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8415));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 224,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8429));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 225,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8445));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 226,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8459));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 227,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8474));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 228,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8491));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 229,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8507));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8522));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 231,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8537));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 232,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8551));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 233,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8568));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 234,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8583));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 235,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8598));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 236,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8615));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 237,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8630));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 238,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8645));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 239,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8660));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 240,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8674));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 241,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8689));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 242,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8704));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 243,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8720));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 244,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8735));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 245,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8749));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 246,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8766));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 247,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8783));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 248,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8798));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 249,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 250,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8830));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 251,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8846));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 252,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8873));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 253,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8891));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 254,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8906));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 255,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8921));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 256,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8938));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 257,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8954));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 258,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 259,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(8989));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 260,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9005));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 261,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9019));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 262,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9034));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 263,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9049));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 264,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9064));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 265,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9080));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 266,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9096));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 267,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9111));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 268,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9127));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 269,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9142));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 270,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9156));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 271,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9172));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 272,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9186));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 273,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9219));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 274,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9233));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 275,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9248));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 276,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9262));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 277,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9278));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 278,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9293));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 279,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9308));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 280,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9323));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 281,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9339));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 282,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9355));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 283,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9373));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 284,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9390));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 285,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9408));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 286,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9425));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 287,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9440));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 288,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9454));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 289,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9469));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 290,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9485));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 291,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9499));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 292,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9515));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 293,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9530));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 294,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9545));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 295,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9562));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 296,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 297,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9595));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 298,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9611));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 299,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9629));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9643));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 301,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9659));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 302,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9673));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 303,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9690));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 304,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9706));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 305,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9721));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 306,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9737));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 307,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9752));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 308,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9767));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 309,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9782));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 310,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9799));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 311,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9815));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 312,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 313,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9847));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 314,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9874));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 315,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9890));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 316,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9905));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 317,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9920));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 318,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9934));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 319,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9950));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 320,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9964));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 321,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9981));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 322,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 359, DateTimeKind.Utc).AddTicks(9995));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 323,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(10));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 324,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(26));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 325,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(44));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 326,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(60));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 327,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(75));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 328,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(90));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 329,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(108));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 330,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(123));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 331,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(137));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 332,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(153));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 333,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(170));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 334,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(185));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 335,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(200));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 336,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(214));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 337,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(230));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 338,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(248));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 339,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(265));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 340,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(282));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 341,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(299));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 342,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 343,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(330));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 344,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(345));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 345,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(361));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 346,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(378));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 347,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(393));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 348,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(431));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 349,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(446));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 350,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(462));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 351,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(478));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 352,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(495));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 353,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(512));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 354,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(528));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 355,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(555));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 356,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(570));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 357,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(586));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 358,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(601));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 359,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(615));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 360,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(630));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 361,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(644));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 362,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(662));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 363,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(678));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 364,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(694));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 365,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(708));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 366,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 367,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(741));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 368,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(758));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 369,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(774));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 370,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(789));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 371,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(804));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 372,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(820));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 373,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(835));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 374,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(849));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 375,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(864));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 376,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(881));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 377,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(895));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 378,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(913));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 379,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(933));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 380,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(948));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 381,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(964));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 382,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(979));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 383,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(995));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 384,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1011));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 385,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1026));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 386,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1042));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 387,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1059));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 388,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1076));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 389,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1091));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 390,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1108));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 391,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1122));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 392,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1137));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 393,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1151));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 394,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1167));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 395,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1194));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 396,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1208));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 397,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1224));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 398,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1241));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 399,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1257));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1273));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 401,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1289));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 402,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1304));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 403,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1319));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 404,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1335));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 405,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1350));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 406,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1365));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 407,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1382));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 408,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1399));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 409,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1413));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 410,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1429));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 411,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1444));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 412,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1459));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 413,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1475));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 414,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1490));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 415,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1506));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 416,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1521));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 417,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1535));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 418,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1553));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 419,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1567));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 420,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1582));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 421,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1598));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 422,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1613));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 423,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1628));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 424,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1643));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 425,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1658));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 426,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1675));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 427,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1691));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 428,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1705));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 429,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1723));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 430,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1739));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 431,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1754));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 432,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1770));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 433,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1790));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 434,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1809));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 435,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1825));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 436,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1855));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 437,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1870));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 438,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1886));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 439,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1900));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 440,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1916));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 441,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1932));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 442,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1947));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 443,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1964));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 444,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1979));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 445,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(1995));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 446,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2012));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 447,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2029));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 448,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2046));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 449,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2063));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 450,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2079));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 451,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2095));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 452,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2111));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 453,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2127));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 454,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2142));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 455,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2157));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 456,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2171));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 457,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2188));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 458,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2203));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 459,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2218));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 460,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2236));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 461,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2250));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 462,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2264));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 463,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2280));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 464,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2294));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 465,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2310));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 466,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2323));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 467,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2339));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 468,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2353));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 469,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2370));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 470,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2386));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 471,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2402));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 472,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2421));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 473,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2437));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 474,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2452));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 475,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2479));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 476,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2496));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 477,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2512));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 478,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2526));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 479,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2541));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 480,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2555));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 481,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2570));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 482,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2584));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 483,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2600));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 484,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2614));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 485,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2630));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 486,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2649));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 487,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2666));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 488,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2681));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 489,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2697));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 490,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2713));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 491,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2733));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 492,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2748));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 493,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2766));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 494,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2780));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 495,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2794));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 496,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2809));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 497,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2824));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 498,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2839));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 499,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2860));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2876));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 501,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2894));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 502,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2908));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 503,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2925));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 504,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2944));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 505,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2960));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 506,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2975));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 507,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(2991));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 508,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3007));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 509,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3021));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 510,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3039));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 511,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3056));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 512,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3070));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 513,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3086));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 514,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3127));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 515,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3144));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 516,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3175));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 517,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3192));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 518,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3211));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 519,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3225));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 520,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3240));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 521,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3256));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 522,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3271));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 523,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3288));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 524,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3302));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 525,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3318));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 526,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3334));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 527,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3351));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 528,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3366));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 529,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3382));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 530,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3396));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 531,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3410));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 532,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3426));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 533,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3442));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 534,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3456));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 535,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3471));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 536,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3486));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 537,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3501));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 538,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3515));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 539,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3532));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 540,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3547));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 541,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3561));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 542,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3577));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 543,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3593));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 544,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3608));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 545,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3623));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 546,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3637));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 547,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3652));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 548,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3666));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 549,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3681));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 550,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3695));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 551,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3711));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 552,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3726));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 553,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3741));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 554,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3757));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 555,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3773));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 556,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3790));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 557,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3804));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 558,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3831));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 559,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3846));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 560,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3861));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 561,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3875));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 562,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3890));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 563,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3904));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 564,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3920));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 565,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3938));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 566,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3954));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 567,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 568,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(3986));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 569,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(4002));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 570,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(4016));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 571,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 572,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(4045));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 573,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(4061));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 574,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(4075));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 575,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(4091));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 576,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(4105));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 577,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(4120));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 578,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(4134));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 579,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(4151));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 580,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(4165));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 581,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 360, DateTimeKind.Utc).AddTicks(4180));

            migrationBuilder.UpdateData(
                schema: "auth",
                table: "roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 355, DateTimeKind.Utc).AddTicks(8575));

            migrationBuilder.UpdateData(
                schema: "auth",
                table: "roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 355, DateTimeKind.Utc).AddTicks(8579));

            migrationBuilder.UpdateData(
                schema: "auth",
                table: "roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 2, 7, 20, 7, 47, 355, DateTimeKind.Utc).AddTicks(8581));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                schema: "auth",
                table: "users");

            migrationBuilder.DropColumn(
                name: "Avatar",
                schema: "auth",
                table: "users");

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8058));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8059));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8060));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8061));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8061));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8062));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8062));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8063));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8063));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8064));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8064));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8065));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8065));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8066));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8066));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8067));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8067));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8068));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8068));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8069));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8069));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8070));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8070));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8071));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8071));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8072));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8072));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8073));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8073));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8074));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8074));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8075));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8075));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8076));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8076));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8077));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8077));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8078));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8078));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8079));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8079));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8079));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8080));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8080));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8081));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8081));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8082));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8082));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8083));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8083));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8084));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8084));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8085));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8085));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8086));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8086));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8087));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8087));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8088));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8088));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8089));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8089));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8090));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8090));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8091));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8091));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8092));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8092));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8093));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8093));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8094));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8094));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8095));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8095));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8096));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8096));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8097));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8097));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8098));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8098));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8099));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8099));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8100));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8100));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8101));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8101));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8102));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8102));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8102));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8103));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8104));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8104));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8105));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8105));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8105));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8106));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8106));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8107));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8108));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8108));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8109));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8109));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8110));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8110));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8111));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8111));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8112));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8112));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8113));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8113));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8114));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8114));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8115));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8116));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8116));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8117));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8117));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8118));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8118));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8119));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8119));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8120));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8120));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8121));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8121));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8122));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8122));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8123));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8123));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8124));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8124));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8125));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8125));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8126));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8126));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8126));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8127));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8128));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8128));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8129));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8129));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8129));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8130));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8130));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8131));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8131));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8132));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8133));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8133));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8134));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8134));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8135));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8135));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8136));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8136));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8137));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8137));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8138));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8138));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8139));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8139));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8139));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8140));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8140));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8141));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8141));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8142));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8143));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8143));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8144));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8144));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8145));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8145));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8146));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8146));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8147));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8147));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8148));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8148));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8149));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8149));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8150));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8150));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8151));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8151));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8152));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8152));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8153));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8153));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8154));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8154));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8155));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8155));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8156));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8156));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8157));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8157));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8158));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8158));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8159));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8159));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8159));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8160));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8160));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8161));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8161));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8162));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8162));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8163));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8163));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8164));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8164));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8165));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8165));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8166));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8166));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8169));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8170));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8170));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8171));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8171));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8172));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8172));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 224,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8173));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 225,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8173));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 226,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8174));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 227,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8174));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 228,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8175));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 229,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8175));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8175));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 231,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8176));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 232,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8176));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 233,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8177));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 234,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8177));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 235,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8178));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 236,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8178));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 237,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8179));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 238,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8179));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 239,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8180));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 240,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8180));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 241,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8181));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 242,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8181));

            migrationBuilder.UpdateData(
                schema: "db",
                table: "countries",
                keyColumn: "Id",
                keyValue: 243,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8182));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "language_levels",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(2554));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "language_levels",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(2556));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "language_levels",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(2558));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "language_levels",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(2559));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "language_levels",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(2561));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "language_levels",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(2562));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "language_levels",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(2564));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "language_levels",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(2566));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(6964));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7029));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7047));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7061));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7076));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7093));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7105));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7119));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7132));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7146));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7162));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7176));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7188));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7201));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7214));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7226));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7239));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7253));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7267));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7280));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7292));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7304));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7317));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7331));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7344));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7357));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7369));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7381));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7394));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7407));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7418));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7444));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7457));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7474));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7488));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7499));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7510));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7523));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7535));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7549));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7560));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7574));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7587));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7599));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7612));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7626));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7637));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7650));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7662));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7674));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7686));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7698));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7710));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7725));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7742));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7753));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7765));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7777));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7790));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7802));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7815));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7827));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7840));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7853));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7867));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7891));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7904));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7916));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7928));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7942));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7954));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7965));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7978));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7990));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8004));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8017));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8028));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8040));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8053));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8065));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8078));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8091));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8103));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8116));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8127));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8139));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8152));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8164));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8176));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8187));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8200));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8212));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8225));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8238));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8250));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8263));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8276));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8290));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8302));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8314));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8327));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8340));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8354));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8366));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8378));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8401));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8414));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8426));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8439));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8451));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8463));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8474));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8486));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8499));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8511));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8523));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8535));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8547));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8560));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8571));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8584));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8596));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8608));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8620));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8632));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8645));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8659));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8672));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8684));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8699));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8712));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8725));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8737));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8749));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8772));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8784));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8797));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8811));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8824));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8837));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8849));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8861));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8873));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8886));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8897));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8909));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8922));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8935));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8947));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8959));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8971));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8983));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8995));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9007));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9019));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9031));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9044));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9055));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9068));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9080));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9093));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9106));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9118));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9130));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9142));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9154));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9166));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9179));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9191));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9203));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9216));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9229));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9252));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9265));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9277));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9288));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9300));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9312));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9324));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9335));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9349));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9362));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9373));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9387));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9399));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9413));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9425));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9438));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9450));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9462));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9474));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9487));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9499));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 194,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9511));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 195,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9524));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 196,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9536));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 197,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9548));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9561));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 199,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9573));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 200,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9585));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 201,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9597));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 202,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9609));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 203,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9621));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 204,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9633));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 205,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9645));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 206,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9657));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 207,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9669));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 208,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9681));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 209,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9692));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 210,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9705));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 211,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9717));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 212,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9741));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 213,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9753));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 214,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9766));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 215,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9779));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 216,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9792));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 217,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9804));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 218,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9817));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 219,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 220,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9842));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 221,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9855));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 222,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9867));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 223,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9880));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 224,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9892));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 225,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9904));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 226,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9916));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 227,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9928));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 228,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9941));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 229,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9954));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 230,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9965));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 231,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9977));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 232,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9989));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 233,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 234,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(13));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 235,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(26));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 236,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(39));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 237,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(51));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 238,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(63));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 239,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(75));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 240,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(87));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 241,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(99));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 242,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(110));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 243,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(123));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 244,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(134));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 245,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(146));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 246,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(159));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 247,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(172));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 248,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(184));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 249,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(197));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 250,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(210));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 251,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(223));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 252,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(245));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 253,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(259));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 254,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(271));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 255,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(282));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 256,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(296));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 257,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(309));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 258,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(326));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 259,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(338));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 260,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(350));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 261,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(361));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 262,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(373));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 263,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(385));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 264,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(397));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 265,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(410));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 266,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(423));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 267,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(435));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 268,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(447));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 269,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(459));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 270,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(470));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 271,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(483));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 272,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(494));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 273,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(520));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 274,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(532));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 275,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(543));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 276,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(555));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 277,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(566));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 278,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(578));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 279,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(590));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 280,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(602));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 281,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(614));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 282,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(627));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 283,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(640));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 284,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(653));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 285,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(666));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 286,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(679));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 287,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(691));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 288,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(702));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 289,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(714));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 290,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(727));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 291,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(738));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 292,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(750));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 293,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(762));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 294,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(774));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 295,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(787));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 296,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(800));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 297,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(811));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 298,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(824));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 299,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(837));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 300,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(849));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 301,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(861));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 302,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(872));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 303,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(885));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 304,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(897));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 305,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(909));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 306,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(922));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 307,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(933));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 308,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(945));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 309,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(956));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 310,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(970));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 311,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(982));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 312,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(993));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 313,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1006));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 314,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1031));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 315,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1043));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 316,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1055));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 317,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1067));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 318,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1077));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 319,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1090));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 320,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1101));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 321,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1114));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 322,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1125));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 323,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1137));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 324,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1149));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 325,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1163));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 326,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1175));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 327,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1187));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 328,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1200));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 329,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1213));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 330,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1225));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 331,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1236));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 332,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1249));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 333,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1261));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 334,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1272));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 335,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1284));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 336,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1295));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 337,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1307));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 338,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1321));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 339,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1334));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 340,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1346));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 341,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1360));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 342,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1373));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 343,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1385));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 344,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1396));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 345,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1408));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 346,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1422));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 347,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1433));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 348,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1457));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 349,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1471));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 350,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1482));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 351,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1494));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 352,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1508));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 353,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1521));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 354,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1534));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 355,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1557));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 356,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1569));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 357,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1582));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 358,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1594));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 359,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1605));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 360,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1617));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 361,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1628));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 362,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1640));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 363,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1652));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 364,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1664));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 365,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1676));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 366,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1688));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 367,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1702));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 368,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1715));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 369,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1727));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 370,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1739));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 371,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1751));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 372,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1764));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 373,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1775));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 374,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1787));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 375,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1799));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 376,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1811));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 377,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1823));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 378,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1837));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 379,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1851));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 380,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1864));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 381,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1875));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 382,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1887));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 383,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1899));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 384,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1911));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 385,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1923));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 386,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1935));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 387,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1948));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 388,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1960));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 389,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1972));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 390,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1984));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 391,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1996));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 392,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2007));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 393,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2019));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 394,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2032));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 395,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2054));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 396,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2066));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 397,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2078));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 398,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2091));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 399,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2104));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 400,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2116));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 401,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2128));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 402,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2139));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 403,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2152));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 404,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2164));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 405,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2177));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 406,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2189));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 407,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2203));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 408,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2214));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 409,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2226));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 410,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2238));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 411,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2249));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 412,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2262));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 413,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2274));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 414,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2285));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 415,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2298));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 416,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2309));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 417,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2321));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 418,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2334));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 419,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2345));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 420,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2358));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 421,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2370));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 422,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2382));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 423,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2394));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 424,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2406));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 425,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2417));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 426,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2430));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 427,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2441));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 428,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2453));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 429,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2465));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 430,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2477));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 431,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2489));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 432,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2501));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 433,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2513));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 434,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2528));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 435,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2540));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 436,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2562));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 437,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2575));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 438,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2586));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 439,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2598));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 440,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2610));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 441,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2622));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 442,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2635));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 443,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2648));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 444,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2660));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 445,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2673));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 446,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2686));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 447,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2699));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 448,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2712));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 449,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2727));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 450,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2739));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 451,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2752));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 452,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2764));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 453,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2777));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 454,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2789));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 455,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2801));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 456,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2812));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 457,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2824));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 458,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2837));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 459,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2849));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 460,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2862));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 461,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2874));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 462,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2885));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 463,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2897));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 464,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2909));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 465,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2921));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 466,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2932));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 467,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2944));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 468,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2955));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 469,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2967));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 470,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2980));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 471,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2992));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 472,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3006));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 473,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3018));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 474,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3030));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 475,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3052));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 476,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3064));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 477,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3076));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 478,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3087));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 479,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3098));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 480,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3110));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 481,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3121));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 482,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3133));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 483,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3145));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 484,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3157));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 485,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3169));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 486,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3183));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 487,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3196));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 488,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3207));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 489,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3219));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 490,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3231));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 491,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3243));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 492,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3255));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 493,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3270));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 494,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3281));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 495,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3292));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 496,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3303));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 497,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3315));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 498,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3327));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 499,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3340));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3352));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 501,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3365));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 502,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3377));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 503,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3389));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 504,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3403));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 505,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3415));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 506,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3427));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 507,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3440));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 508,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3452));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 509,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3463));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 510,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3477));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 511,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3491));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 512,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3502));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 513,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3514));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 514,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3545));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 515,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3559));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 516,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3583));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 517,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3597));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 518,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3611));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 519,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3622));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 520,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3634));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 521,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3646));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 522,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3658));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 523,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3670));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 524,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3682));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 525,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3695));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 526,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3707));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 527,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3720));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 528,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3733));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 529,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3746));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 530,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3757));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 531,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 532,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3782));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 533,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3794));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 534,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3805));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 535,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3818));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 536,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3829));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 537,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3841));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 538,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3853));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 539,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3866));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 540,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3878));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 541,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3889));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 542,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3902));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 543,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3914));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 544,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3926));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 545,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3938));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 546,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3950));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 547,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3962));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 548,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3973));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 549,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3985));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 550,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3996));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 551,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4008));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 552,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4020));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 553,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4032));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 554,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4045));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 555,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4058));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 556,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4071));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 557,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4083));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 558,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4106));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 559,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4118));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 560,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4130));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 561,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4142));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 562,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4153));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 563,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4164));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 564,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4178));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 565,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4191));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 566,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4203));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 567,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4215));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 568,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4228));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 569,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4240));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 570,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4251));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 571,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4263));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 572,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4274));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 573,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4286));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 574,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4298));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 575,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4310));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 576,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4321));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 577,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4333));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 578,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4344));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 579,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4356));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 580,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4367));

            migrationBuilder.UpdateData(
                schema: "lrn",
                table: "languages",
                keyColumn: "Id",
                keyValue: 581,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4378));

            migrationBuilder.UpdateData(
                schema: "auth",
                table: "roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(2313));

            migrationBuilder.UpdateData(
                schema: "auth",
                table: "roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(2318));

            migrationBuilder.UpdateData(
                schema: "auth",
                table: "roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(2320));
        }
    }
}
