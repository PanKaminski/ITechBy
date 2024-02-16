using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Implementations.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "db");

            migrationBuilder.EnsureSchema(
                name: "msg");

            migrationBuilder.EnsureSchema(
                name: "lrn");

            migrationBuilder.EnsureSchema(
                name: "auth");

            migrationBuilder.CreateTable(
                name: "achievements",
                schema: "db",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Picture = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ChangedByAccount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_achievements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "conversation_roles",
                schema: "msg",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conversation_roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "conversations",
                schema: "msg",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(64)", nullable: true),
                    Avatar = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conversations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "countries",
                schema: "db",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "varchar(10)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "language_levels",
                schema: "lrn",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Level = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_language_levels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "languages",
                schema: "lrn",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "varchar(10)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NativeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "roles",
                schema: "auth",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                schema: "auth",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(36)", nullable: true),
                    LastName = table.Column<string>(type: "varchar(36)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ChangedByAccount = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "varchar(36)", nullable: true),
                    PasswordHash = table.Column<string>(type: "varchar(256)", nullable: true),
                    PasswordSalt = table.Column<string>(type: "varchar(256)", nullable: true),
                    VerificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VerificationToken = table.Column<string>(type: "varchar(256)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ResetToken = table.Column<string>(type: "varchar(256)", nullable: true),
                    ResetTokenExpires = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PasswordResetTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_users_countries_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "db",
                        principalTable: "countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "connections",
                schema: "db",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    UserFromId = table.Column<int>(type: "int", nullable: false),
                    UserToId = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_connections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_connections_users_UserFromId",
                        column: x => x.UserFromId,
                        principalSchema: "auth",
                        principalTable: "users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_connections_users_UserToId",
                        column: x => x.UserToId,
                        principalSchema: "auth",
                        principalTable: "users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "messages",
                schema: "msg",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConversationId = table.Column<int>(type: "int", nullable: false),
                    SenderId = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ChangedByAccount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_messages_conversations_ConversationId",
                        column: x => x.ConversationId,
                        principalSchema: "msg",
                        principalTable: "conversations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_messages_users_SenderId",
                        column: x => x.SenderId,
                        principalSchema: "auth",
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "refresh_tokens",
                schema: "auth",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Source = table.Column<string>(type: "varchar(256)", nullable: true),
                    ExpireTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_refresh_tokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_refresh_tokens_users_UserId",
                        column: x => x.UserId,
                        principalSchema: "auth",
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "social_links",
                schema: "db",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SocialType = table.Column<int>(type: "int", nullable: false),
                    Link = table.Column<string>(type: "varchar(256)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_social_links", x => x.Id);
                    table.ForeignKey(
                        name: "FK_social_links_users_UserId",
                        column: x => x.UserId,
                        principalSchema: "auth",
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "user_achievements",
                columns: table => new
                {
                    UsersId = table.Column<int>(type: "int", nullable: false),
                    AchievementsId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    AchievementId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_achievements", x => new { x.AchievementsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_user_achievements_achievements_AchievementId",
                        column: x => x.AchievementId,
                        principalSchema: "db",
                        principalTable: "achievements",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_user_achievements_achievements_AchievementsId",
                        column: x => x.AchievementsId,
                        principalSchema: "db",
                        principalTable: "achievements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_user_achievements_users_UserId",
                        column: x => x.UserId,
                        principalSchema: "auth",
                        principalTable: "users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_user_achievements_users_UsersId",
                        column: x => x.UsersId,
                        principalSchema: "auth",
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "user_conversations",
                schema: "msg",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConversationRoleId = table.Column<int>(type: "int", nullable: false),
                    ConversationId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_conversations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_user_conversations_conversation_roles_ConversationRoleId",
                        column: x => x.ConversationRoleId,
                        principalSchema: "msg",
                        principalTable: "conversation_roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_user_conversations_conversations_ConversationId",
                        column: x => x.ConversationId,
                        principalSchema: "msg",
                        principalTable: "conversations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_user_conversations_users_UserId",
                        column: x => x.UserId,
                        principalSchema: "auth",
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "user_languages",
                schema: "lrn",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    LevelId = table.Column<int>(type: "int", nullable: false),
                    IsInLearning = table.Column<bool>(type: "bit", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_languages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_user_languages_language_levels_LevelId",
                        column: x => x.LevelId,
                        principalSchema: "lrn",
                        principalTable: "language_levels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_user_languages_languages_LanguageId",
                        column: x => x.LanguageId,
                        principalSchema: "lrn",
                        principalTable: "languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_user_languages_users_UserId",
                        column: x => x.UserId,
                        principalSchema: "auth",
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "user_roles",
                schema: "auth",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_roles", x => new { x.RoleId, x.UserId });
                    table.ForeignKey(
                        name: "FK_user_roles_roles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "auth",
                        principalTable: "roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_user_roles_users_UserId",
                        column: x => x.UserId,
                        principalSchema: "auth",
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "attachments",
                schema: "msg",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageId = table.Column<int>(type: "int", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ChangedByAccount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_attachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_attachments_messages_MessageId",
                        column: x => x.MessageId,
                        principalSchema: "msg",
                        principalTable: "messages",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                schema: "db",
                table: "countries",
                columns: new[] { "Id", "Code", "CreatedTime", "Name", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, "AF", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8058), "Afghanistan", null },
                    { 2, "AX", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8059), "Åland Islands", null },
                    { 3, "AL", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8060), "Albania", null },
                    { 4, "DZ", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8061), "Algeria", null },
                    { 5, "AS", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8061), "American Samoa", null },
                    { 6, "AD", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8062), "AndorrA", null },
                    { 7, "AO", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8062), "Angola", null },
                    { 8, "AI", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8063), "Anguilla", null },
                    { 9, "AQ", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8063), "Antarctica", null },
                    { 10, "AG", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8064), "Antigua and Barbuda", null },
                    { 11, "AR", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8064), "Argentina", null },
                    { 12, "AM", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8065), "Armenia", null },
                    { 13, "AW", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8065), "Aruba", null },
                    { 14, "AU", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8066), "Australia", null },
                    { 15, "AT", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8066), "Austria", null },
                    { 16, "AZ", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8067), "Azerbaijan", null },
                    { 17, "BS", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8067), "Bahamas", null },
                    { 18, "BH", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8068), "Bahrain", null },
                    { 19, "BD", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8068), "Bangladesh", null },
                    { 20, "BB", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8069), "Barbados", null },
                    { 21, "BY", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8069), "Belarus", null },
                    { 22, "BE", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8070), "Belgium", null },
                    { 23, "BZ", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8070), "Belize", null },
                    { 24, "BJ", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8071), "Benin", null },
                    { 25, "BM", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8071), "Bermuda", null },
                    { 26, "BT", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8072), "Bhutan", null },
                    { 27, "BO", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8072), "Bolivia", null },
                    { 28, "BA", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8073), "Bosnia and Herzegovina", null },
                    { 29, "BW", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8073), "Botswana", null },
                    { 30, "BV", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8074), "Bouvet Island", null },
                    { 31, "BR", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8074), "Brazil", null },
                    { 32, "IO", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8075), "British Indian Ocean Territory", null },
                    { 33, "BN", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8075), "Brunei Darussalam", null },
                    { 34, "BG", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8076), "Bulgaria", null },
                    { 35, "BF", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8076), "Burkina Faso", null },
                    { 36, "BI", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8077), "Burundi", null },
                    { 37, "KH", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8077), "Cambodia", null },
                    { 38, "CM", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8078), "Cameroon", null },
                    { 39, "CA", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8078), "Canada", null },
                    { 40, "CV", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8079), "Cape Verde", null },
                    { 41, "KY", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8079), "Cayman Islands", null },
                    { 42, "CF", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8079), "Central African Republic", null },
                    { 43, "TD", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8080), "Chad", null },
                    { 44, "CL", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8080), "Chile", null },
                    { 45, "CN", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8081), "China", null },
                    { 46, "CX", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8081), "Christmas Island", null },
                    { 47, "CC", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8082), "Cocos (Keeling) Islands", null },
                    { 48, "CO", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8082), "Colombia", null },
                    { 49, "KM", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8083), "Comoros", null },
                    { 50, "CG", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8083), "Congo", null },
                    { 51, "CD", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8084), "Congo, The Democratic Republic of the", null },
                    { 52, "CK", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8084), "Cook Islands", null },
                    { 53, "CR", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8085), "Costa Rica", null },
                    { 54, "CI", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8085), "Cote D\"Ivoire", null },
                    { 55, "HR", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8086), "Croatia", null },
                    { 56, "CU", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8086), "Cuba", null },
                    { 57, "CY", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8087), "Cyprus", null },
                    { 58, "CZ", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8087), "Czech Republic", null },
                    { 59, "DK", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8088), "Denmark", null },
                    { 60, "DJ", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8088), "Djibouti", null },
                    { 61, "DM", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8089), "Dominica", null },
                    { 62, "DO", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8089), "Dominican Republic", null },
                    { 63, "EC", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8090), "Ecuador", null },
                    { 64, "EG", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8090), "Egypt", null },
                    { 65, "SV", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8091), "El Salvador", null },
                    { 66, "GQ", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8091), "Equatorial Guinea", null },
                    { 67, "ER", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8092), "Eritrea", null },
                    { 68, "EE", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8092), "Estonia", null },
                    { 69, "ET", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8093), "Ethiopia", null },
                    { 70, "FK", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8093), "Falkland Islands (Malvinas)", null },
                    { 71, "FO", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8094), "Faroe Islands", null },
                    { 72, "FJ", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8094), "Fiji", null },
                    { 73, "FI", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8095), "Finland", null },
                    { 74, "FR", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8095), "France", null },
                    { 75, "GF", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8096), "French Guiana", null },
                    { 76, "PF", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8096), "French Polynesia", null },
                    { 77, "TF", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8097), "French Southern Territories", null },
                    { 78, "GA", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8097), "Gabon", null },
                    { 79, "GM", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8098), "Gambia", null },
                    { 80, "GE", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8098), "Georgia", null },
                    { 81, "DE", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8099), "Germany", null },
                    { 82, "GH", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8099), "Ghana", null },
                    { 83, "GI", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8100), "Gibraltar", null },
                    { 84, "GR", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8100), "Greece", null },
                    { 85, "GL", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8101), "Greenland", null },
                    { 86, "GD", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8101), "Grenada", null },
                    { 87, "GP", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8102), "Guadeloupe", null },
                    { 88, "GU", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8102), "Guam", null },
                    { 89, "GT", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8102), "Guatemala", null },
                    { 90, "GG", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8103), "Guernsey", null },
                    { 91, "GN", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8104), "Guinea", null },
                    { 92, "GW", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8104), "Guinea-Bissau", null },
                    { 93, "GY", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8105), "Guyana", null },
                    { 94, "HT", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8105), "Haiti", null },
                    { 95, "HM", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8105), "Heard Island and Mcdonald Islands", null },
                    { 96, "VA", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8106), "Holy See (Vatican City State)", null },
                    { 97, "HN", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8106), "Honduras", null },
                    { 98, "HK", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8107), "Hong Kong", null },
                    { 99, "HU", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8108), "Hungary", null },
                    { 100, "IS", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8108), "Iceland", null },
                    { 101, "IN", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8109), "India", null },
                    { 102, "ID", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8109), "Indonesia", null },
                    { 103, "IR", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8110), "Iran, Islamic Republic Of", null },
                    { 104, "IQ", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8110), "Iraq", null },
                    { 105, "IE", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8111), "Ireland", null },
                    { 106, "IM", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8111), "Isle of Man", null },
                    { 107, "IL", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8112), "Israel", null },
                    { 108, "IT", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8112), "Italy", null },
                    { 109, "JM", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8113), "Jamaica", null },
                    { 110, "JP", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8113), "Japan", null },
                    { 111, "JE", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8114), "Jersey", null },
                    { 112, "JO", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8114), "Jordan", null },
                    { 113, "KZ", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8115), "Kazakhstan", null },
                    { 114, "KE", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8116), "Kenya", null },
                    { 115, "KI", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8116), "Kiribati", null },
                    { 116, "KP", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8117), "Korea, Democratic People\"S Republic of", null },
                    { 117, "KR", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8117), "Korea, Republic of", null },
                    { 118, "KW", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8118), "Kuwait", null },
                    { 119, "KG", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8118), "Kyrgyzstan", null },
                    { 120, "LA", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8119), "Lao People\"S Democratic Republic", null },
                    { 121, "LV", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8119), "Latvia", null },
                    { 122, "LB", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8120), "Lebanon", null },
                    { 123, "LS", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8120), "Lesotho", null },
                    { 124, "LR", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8121), "Liberia", null },
                    { 125, "LY", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8121), "Libyan Arab Jamahiriya", null },
                    { 126, "LI", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8122), "Liechtenstein", null },
                    { 127, "LT", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8122), "Lithuania", null },
                    { 128, "LU", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8123), "Luxembourg", null },
                    { 129, "MO", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8123), "Macao", null },
                    { 130, "MK", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8124), "Macedonia, The Former Yugoslav Republic of", null },
                    { 131, "MG", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8124), "Madagascar", null },
                    { 132, "MW", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8125), "Malawi", null },
                    { 133, "MY", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8125), "Malaysia", null },
                    { 134, "MV", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8126), "Maldives", null },
                    { 135, "ML", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8126), "Mali", null },
                    { 136, "MT", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8126), "Malta", null },
                    { 137, "MH", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8127), "Marshall Islands", null },
                    { 138, "MQ", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8128), "Martinique", null },
                    { 139, "MR", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8128), "Mauritania", null },
                    { 140, "MU", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8129), "Mauritius", null },
                    { 141, "YT", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8129), "Mayotte", null },
                    { 142, "MX", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8129), "Mexico", null },
                    { 143, "FM", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8130), "Micronesia, Federated States of", null },
                    { 144, "MD", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8130), "Moldova, Republic of", null },
                    { 145, "MC", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8131), "Monaco", null },
                    { 146, "MN", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8131), "Mongolia", null },
                    { 147, "MS", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8132), "Montserrat", null },
                    { 148, "MA", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8133), "Morocco", null },
                    { 149, "MZ", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8133), "Mozambique", null },
                    { 150, "MM", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8134), "Myanmar", null },
                    { 151, "NA", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8134), "Namibia", null },
                    { 152, "NR", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8135), "Nauru", null },
                    { 153, "NP", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8135), "Nepal", null },
                    { 154, "NL", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8136), "Netherlands", null },
                    { 155, "AN", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8136), "Netherlands Antilles", null },
                    { 156, "NC", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8137), "New Caledonia", null },
                    { 157, "NZ", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8137), "New Zealand", null },
                    { 158, "NI", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8138), "Nicaragua", null },
                    { 159, "NE", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8138), "Niger", null },
                    { 160, "NG", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8139), "Nigeria", null },
                    { 161, "NU", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8139), "Niue", null },
                    { 162, "NF", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8139), "Norfolk Island", null },
                    { 163, "MP", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8140), "Northern Mariana Islands", null },
                    { 164, "NO", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8140), "Norway", null },
                    { 165, "OM", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8141), "Oman", null },
                    { 166, "PK", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8141), "Pakistan", null },
                    { 167, "PW", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8142), "Palau", null },
                    { 168, "PS", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8143), "Palestinian Territory, Occupied", null },
                    { 169, "PA", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8143), "Panama", null },
                    { 170, "PG", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8144), "Papua New Guinea", null },
                    { 171, "PY", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8144), "Paraguay", null },
                    { 172, "PE", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8145), "Peru", null },
                    { 173, "PH", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8145), "Philippines", null },
                    { 174, "PN", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8146), "Pitcairn", null },
                    { 175, "PL", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8146), "Poland", null },
                    { 176, "PT", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8147), "Portugal", null },
                    { 177, "PR", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8147), "Puerto Rico", null },
                    { 178, "QA", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8148), "Qatar", null },
                    { 179, "RE", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8148), "Reunion", null },
                    { 180, "RO", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8149), "Romania", null },
                    { 181, "RU", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8149), "Russian Federation", null },
                    { 182, "RW", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8150), "RWANDA", null },
                    { 183, "SH", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8150), "Saint Helena", null },
                    { 184, "KN", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8151), "Saint Kitts and Nevis", null },
                    { 185, "LC", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8151), "Saint Lucia", null },
                    { 186, "PM", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8152), "Saint Pierre and Miquelon", null },
                    { 187, "VC", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8152), "Saint Vincent and the Grenadines", null },
                    { 188, "WS", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8153), "Samoa", null },
                    { 189, "SM", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8153), "San Marino", null },
                    { 190, "ST", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8154), "Sao Tome and Principe", null },
                    { 191, "SA", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8154), "Saudi Arabia", null },
                    { 192, "SN", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8155), "Senegal", null },
                    { 193, "CS", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8155), "Serbia and Montenegro", null },
                    { 194, "SC", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8156), "Seychelles", null },
                    { 195, "SL", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8156), "Sierra Leone", null },
                    { 196, "SG", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8157), "Singapore", null },
                    { 197, "SK", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8157), "Slovakia", null },
                    { 198, "SI", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8158), "Slovenia", null },
                    { 199, "SB", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8158), "Solomon Islands", null },
                    { 200, "SO", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8159), "Somalia", null },
                    { 201, "ZA", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8159), "South Africa", null },
                    { 202, "GS", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8159), "South Georgia and the South Sandwich Islands", null },
                    { 203, "ES", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8160), "Spain", null },
                    { 204, "LK", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8160), "Sri Lanka", null },
                    { 205, "SD", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8161), "Sudan", null },
                    { 206, "SR", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8161), "Suri", null },
                    { 207, "SJ", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8162), "Svalbard and Jan Mayen", null },
                    { 208, "SZ", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8162), "Swaziland", null },
                    { 209, "SE", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8163), "Sweden", null },
                    { 210, "CH", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8163), "Switzerland", null },
                    { 211, "SY", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8164), "Syrian Arab Republic", null },
                    { 212, "TW", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8164), "Taiwan, Province of China", null },
                    { 213, "TJ", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8165), "Tajikistan", null },
                    { 214, "TZ", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8165), "Tanzania, United Republic of", null },
                    { 215, "TH", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8166), "Thailand", null },
                    { 216, "TL", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8166), "Timor-Leste", null },
                    { 217, "TG", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8169), "Togo", null },
                    { 218, "TK", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8170), "Tokelau", null },
                    { 219, "TO", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8170), "Tonga", null },
                    { 220, "TT", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8171), "Trinidad and Tobago", null },
                    { 221, "TN", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8171), "Tunisia", null },
                    { 222, "TR", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8172), "Turkey", null },
                    { 223, "TM", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8172), "Turkmenistan", null },
                    { 224, "TC", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8173), "Turks and Caicos Islands", null },
                    { 225, "TV", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8173), "Tuvalu", null },
                    { 226, "UG", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8174), "Uganda", null },
                    { 227, "UA", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8174), "Ukraine", null },
                    { 228, "AE", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8175), "United Arab Emirates", null },
                    { 229, "GB", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8175), "United Kingdom", null },
                    { 230, "US", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8175), "United States", null },
                    { 231, "UM", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8176), "United States Minor Outlying Islands", null },
                    { 232, "UY", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8176), "Uruguay", null },
                    { 233, "UZ", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8177), "Uzbekistan", null },
                    { 234, "VU", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8177), "Vanuatu", null },
                    { 235, "VE", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8178), "Venezuela", null },
                    { 236, "VN", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8178), "Viet Nam", null },
                    { 237, "VG", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8179), "Virgin Islands, British", null },
                    { 238, "VI", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8179), "Virgin Islands, U.S.", null },
                    { 239, "WF", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8180), "Wallis and Futuna", null },
                    { 240, "EH", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8180), "Western Sahara", null },
                    { 241, "YE", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8181), "Yemen", null },
                    { 242, "ZM", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8181), "Zambia", null },
                    { 243, "ZW", new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(8182), "Zimbabwe", null }
                });

            migrationBuilder.InsertData(
                schema: "lrn",
                table: "language_levels",
                columns: new[] { "Id", "CreatedTime", "Level", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(2554), "None", null },
                    { 2, new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(2556), "Beginner", null },
                    { 3, new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(2558), "Elementary", null },
                    { 4, new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(2559), "Intermediate", null },
                    { 5, new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(2561), "UpperIntermediate", null },
                    { 6, new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(2562), "Advanced", null },
                    { 7, new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(2564), "Proficiency", null },
                    { 8, new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(2566), "Native", null }
                });

            migrationBuilder.InsertData(
                schema: "lrn",
                table: "languages",
                columns: new[] { "Id", "Code", "CreatedTime", "Name", "NativeName", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, "aau", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(6964), "Abau", "Abau", null },
                    { 2, "abq", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7029), "Abaza", "Абаза Бызшва", null },
                    { 3, "ab", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7047), "Abkhaz", "Aҧсуа бызшәа", null },
                    { 4, "ady", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7061), "Adyghe", "Адыгaбзэ", null },
                    { 5, "kbd", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7076), "Kabardian", "Адыгэбзэ", null },
                    { 6, "af", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7093), "Afrikaans", "Afrikaans", null },
                    { 7, "oj", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7105), "Ojibwe", "ᐊᓂᔑᓈᐯ", null },
                    { 8, "ain", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7119), "Ainu", "アイヌイタク", null },
                    { 9, "ar", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7132), "Arabic", "العربية", null },
                    { 10, "ar-sa", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7146), "Arabic, Saudi Arabian", "العربية - اللهجة السعودية", null },
                    { 11, "ar-dz", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7162), "Arabic, Algerian", "العربية - اللهجة الجزائرية", null },
                    { 12, "ar-acy", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7176), "Arabic, Cypriot Maronite", "Sanna", null },
                    { 13, "ar-afb", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7188), "Arabic, Gulf", "العربية - اللهجة الخليجية", null },
                    { 14, "ar-eg", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7201), "Arabic, Egyptian", "العربية - اللهجة المصرية", null },
                    { 15, "ar-ma", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7214), "Arabic, Moroccan", "العربية - اللهجة المغربية", null },
                    { 16, "ar-apc", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7226), "Arabic, Levantine", "العربية - اللهجة الشامية", null },
                    { 17, "ar-lb", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7239), "Arabic, Lebanese", "العربية - اللهجة اللبنانية", null },
                    { 18, "ar-ly", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7253), "Arabic, Libyan", "العربية - اللهجة الشامية", null },
                    { 19, "ar-iq", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7267), "Arabic, Iraqi", "العربية - اللهجة العراقية", null },
                    { 20, "ar-sd", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7280), "Arabic, Sudanese", "العربية - اللهجة السودانية", null },
                    { 21, "ar-tn", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7292), "Arabic, Tunesian", "العربية - اللهجة التونسية", null },
                    { 22, "ar-arb", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7304), "Arabic, Standard", "العربية - الفصحى", null },
                    { 23, "akk", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7317), "Akkadian", "lišānum akkadītum", null },
                    { 24, "agx", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7331), "Aghul", "агъул чӀал", null },
                    { 25, "ofs", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7344), "Old Frisian", "Aldfrysk", null },
                    { 26, "atv", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7357), "Altay, Northern", "Алтай", null },
                    { 27, "alt", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7369), "Altay, Southern", "Алтай", null },
                    { 28, "alq", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7381), "Algonquin", "Anicinâbemowin", null },
                    { 29, "am", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7394), "Amharic", "አማርኛ", null },
                    { 30, "an", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7407), "Aragonese", "Aragones", null },
                    { 31, "frp", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7418), "Franco-Provençal", "arpetan", null },
                    { 32, "xno", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7444), "Anglo-Norman", "Anglo-normand", null },
                    { 33, "apw", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7457), "Apache (Western)", "Nṉēē biyáti’", null },
                    { 34, "arc", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7474), "Aramaic", "אַרָמִית", null },
                    { 35, "arw", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7488), "Arawak", "Arawak", null },
                    { 36, "aqc", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7499), "Archi", "Archi", null },
                    { 37, "rup", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7510), "Aromanian", "Armãneashce", null },
                    { 38, "aer", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7523), "Arrernte", "Arrernte angkentye", null },
                    { 39, "as", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7535), "Assamese", "অসিময়া", null },
                    { 40, "ast", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7549), "Asturian", "Asturianu", null },
                    { 41, "akv", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7560), "Akhvakh", "Ашвaлъи мицIи", null },
                    { 42, "av", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7574), "Avar", "Авар мацІ", null },
                    { 43, "ae", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7587), "Avestan", "Avestan", null },
                    { 44, "ay", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7599), "Aymara", "Aymará", null },
                    { 45, "az", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7612), "Azerbaijani", "Azərbaycanca", null },
                    { 46, "kva", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7626), "Bagvalal", "Bagvalal", null },
                    { 47, "ace", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7637), "Acehnese", "Basa Acèh", null },
                    { 48, "ms", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7650), "Malay", "Bahasa Melayu", null },
                    { 49, "ba", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7662), "Bashkir", "Башҡортса", null },
                    { 50, "ban", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7674), "Balinese", "Basa Bali", null },
                    { 51, "bbl", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7686), "Bats", "batsba motjiti", null },
                    { 52, "be", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7698), "Belarusian", "Беларускі", null },
                    { 53, "be-tara", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7710), "Belarusian [Taraškievica]", "тарашкевіца", null },
                    { 54, "bpy", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7725), "Bishnupriya Manipuri", "ইমার ঠার/বিষ্ণুপ্রিয়া মণিপুরী", null },
                    { 55, "bue", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7742), "Beothuk", "Beothukan", null },
                    { 56, "bis", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7753), "Bislama", "Bislama", null },
                    { 57, "bg", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7765), "Bulgarian", "Български", null },
                    { 58, "bla", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7777), "Blackfoot", "Siksiká", null },
                    { 59, "bm", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7790), "Bamanankan", "Bambara", null },
                    { 60, "bn", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7802), "Bengali", "বাংলা", null },
                    { 61, "bo", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7815), "Tibetan", "བོད་སྐད་", null },
                    { 62, "bod", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7827), "Classical Tibetan", "བོད་སྐད་", null },
                    { 63, "kap", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7840), "Bezhta", "бежкьалас миц", null },
                    { 64, "blc", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7853), "Nuxálk", "Bella Coola", null },
                    { 65, "br", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7867), "Breton", "Brezhoneg", null },
                    { 66, "brx", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7891), "Bodo", "बड़ो", null },
                    { 67, "bs", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7904), "Bosnian", "Bosanski", null },
                    { 68, "bdk", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7916), "Budukh", "Будад мез", null },
                    { 69, "bph", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7928), "Botlikh", "Буйхaлъи мицIцIи", null },
                    { 70, "bua", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7942), "Buryat", "буряад", null },
                    { 71, "bug", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7954), "Buginese", "Basa Ugi", null },
                    { 72, "bsk", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7965), "Burushaski", "بروشسکی", null },
                    { 73, "ca", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7978), "Catalan", "Català", null },
                    { 74, "cay", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(7990), "Cayuga", "Gayogohó:nǫ’", null },
                    { 75, "ce", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8004), "Chechen", "Нохчийн мотт", null },
                    { 76, "ceb", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8017), "Cebuano", "Cebuano", null },
                    { 77, "cho", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8028), "Choctaw", "Chahta Anumpa", null },
                    { 78, "cji", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8040), "Chamalal", "чамалалдуб мичIчI", null },
                    { 79, "ch", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8053), "Chamorro", "Chamoru", null },
                    { 80, "chr", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8065), "Cherokee", "ᏣᎳᎩ", null },
                    { 81, "cs", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8078), "Czech", "Čeština", null },
                    { 82, "chg", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8091), "Chagatai", "جغتای", null },
                    { 83, "chn", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8103), "Chinook Jargon", "Chinook wawa", null },
                    { 84, "sn", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8116), "Shona", "chiShona", null },
                    { 85, "co", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8127), "Corsican", "Corsu", null },
                    { 86, "cop", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8139), "Coptic", "ⲙⲛⲧⲣⲙⲛⲕⲏⲙⲉ", null },
                    { 87, "cv", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8152), "Chuvash", "чӑваш чӗлхи", null },
                    { 88, "cy", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8164), "Welsh", "Cymraeg", null },
                    { 89, "da", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8176), "Danish", "Dansk", null },
                    { 90, "dak", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8187), "Dakota", "Dakȟótiyapi", null },
                    { 91, "dlc", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8200), "Dalecarlian", "Dalska", null },
                    { 92, "dar", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8212), "Dargwa", "дарган мез", null },
                    { 93, "dng", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8225), "Dungan", "Хуэйзў йүян", null },
                    { 94, "zap", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8238), "Zapotec", "Diidzaj", null },
                    { 95, "dsb", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8250), "Sorbian (lower)", "Dolnoserbšćina", null },
                    { 96, "koy", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8263), "Koyukon", "Denaakkʼe", null },
                    { 97, "lut", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8276), "Lushootseed", "dxʷləšucid", null },
                    { 98, "lad", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8290), "Ladino", "Djudeo-espanyol", null },
                    { 99, "de", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8302), "German", "Deutsch", null },
                    { 100, "de-at", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8314), "Austrian German", "Österreichisch", null },
                    { 101, "de-ch", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8327), "Swiss Standard German", "Schweizer Hochdeutsch", null },
                    { 102, "de-gsw", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8340), "Swiss German", "Schwyzerdütsch", null },
                    { 103, "de-goh", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8354), "Old High German", "Althochdeutsch", null },
                    { 104, "de-gmh", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8366), "Middle High German", "Mittelhochdeutsch", null },
                    { 105, "de-osx", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8378), "Old Saxon", "Altsächsisch", null },
                    { 106, "nv", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8401), "Navajo", "Diné bizaad", null },
                    { 107, "dv", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8414), "Dhivehi", "ދިވެހިބަސ", null },
                    { 108, "dz", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8426), "Dzongkha", "༄༅ཇོ༹ང་ཁ", null },
                    { 109, "et", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8439), "Estonian", "Eesti", null },
                    { 110, "egy", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8451), "Egyptian, ancient", "Egyptian, ancient", null },
                    { 111, "elx", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8463), "Elamite", "Elamite", null },
                    { 112, "el", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8474), "Greek", "Ελληνικά", null },
                    { 113, "el-cy", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8486), "Greek, Cypriot", "Κυπριακά", null },
                    { 114, "el-ka", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8499), "Greek, Katharevousa", "Καθαρεύουσα", null },
                    { 115, "en", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8511), "English", "English", null },
                    { 116, "en-us", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8523), "American English", "American English", null },
                    { 117, "en-gb", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8535), "British English", "British English", null },
                    { 118, "en-au", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8547), "Australian English", "Australian English", null },
                    { 119, "en-ca", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8560), "Canadian English", "Canadian English", null },
                    { 120, "en-nz", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8571), "New Zealand English", "New Zealand English", null },
                    { 121, "en-ie", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8584), "Irish English", "Irish English", null },
                    { 122, "en-sg", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8596), "Singapore English", "Singapore English", null },
                    { 123, "en-old", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8608), "Old English", "Ænglisc", null },
                    { 124, "en-mid", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8620), "Middle English", "Middle English", null },
                    { 125, "es", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8632), "Spanish", "Español", null },
                    { 126, "es-es", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8645), "Spanish, Spain", "Español de España", null },
                    { 127, "es-mx", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8659), "Mexican Spanish", "Español de México", null },
                    { 128, "es-ar", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8672), "Argentinian Spanish", "Español de Argentina", null },
                    { 129, "es-cl", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8684), "Chilean Spanish", "Español de Chile", null },
                    { 130, "es-pe", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8699), "Peruvian Spanish", "Español de Perú", null },
                    { 131, "es-ve", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8712), "Venezuelan Spanish", "Español de Venezuela", null },
                    { 132, "es-co", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8725), "Colombian Spanish", "Español de Colombia", null },
                    { 133, "es-bo", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8737), "Bolivian Spanish", "Español de Bolivia", null },
                    { 134, "es-py", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8749), "Paraguayan Spanish", "Español de Paraguay", null },
                    { 135, "es-uy", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8772), "Uruguayan Spanish", "Español de Uruguay", null },
                    { 136, "es-cu", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8784), "Cuban Spanish", "Español de Cuba", null },
                    { 137, "es-do", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8797), "Dominican Spanish", "Español de la República Dominicana", null },
                    { 138, "es-pa", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8811), "Panamanian Spanish", "Español de Panamá", null },
                    { 139, "es-cr", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8824), "Costa Rican Spanish", "Español de Costa Rica", null },
                    { 140, "es-hn", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8837), "Honduran Spanish", "Español de Honduras", null },
                    { 141, "es-ni", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8849), "Nicaraguan Spanish", "Español de Nicaragua", null },
                    { 142, "es-old", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8861), "Old Spanish", "Castellano antiguo", null },
                    { 143, "es-sv", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8873), "Salvadoran Spanish", "Español de El Salvador", null },
                    { 144, "es-gt", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8886), "Guatemalan Spanish", "Español de Guatemala", null },
                    { 145, "es-pr", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8897), "Puerto Rican Spanish", "Español de Puerto Rico", null },
                    { 146, "es-an", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8909), "Andalusian Spanish", "Español de Andalucía", null },
                    { 147, "sux", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8922), "Sumerian", "eme-ĝir", null },
                    { 148, "egl", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8935), "Emiliano", "Emigliàn", null },
                    { 149, "enq", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8947), "Enga", "Enga", null },
                    { 150, "eo", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8959), "Esperanto", "Esperanto", null },
                    { 151, "ext", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8971), "Extremaduran", "Estremeñu", null },
                    { 152, "eu", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8983), "Basque", "Euskara", null },
                    { 153, "myv", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(8995), "Erzya", "Эрзянь", null },
                    { 154, "evn", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9007), "Evenki", "Эвэнки", null },
                    { 155, "ee", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9019), "Ewe", "Èʋegbe", null },
                    { 156, "ett", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9031), "Etruscan", "mechl Rasnal", null },
                    { 157, "wls", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9044), "Wallisian", "Fakaʻuvea", null },
                    { 158, "fa", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9055), "Persian", "فارسی", null },
                    { 159, "fa-af", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9068), "Dari", "درى", null },
                    { 160, "fa-old", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9080), "Old Persian", "*Pārsīka", null },
                    { 161, "fa-mid", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9093), "Middle Persian", "Pārsīk", null },
                    { 162, "fa-tj", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9106), "Tajik", "тоҷикӣ", null },
                    { 163, "fj", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9118), "Fijian", "Na vosa Vakaviti", null },
                    { 164, "fo", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9130), "Faroese", "Føroyskt", null },
                    { 165, "fr", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9142), "French", "Français", null },
                    { 166, "fr-ac", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9154), "Acadian French", "Acadien", null },
                    { 167, "fr-be", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9166), "Belgian French", "Français Belge", null },
                    { 168, "fr-ca", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9179), "Canadian French", "Français du Canada", null },
                    { 169, "fr-ch", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9191), "Swiss French", "Français de la Suisse", null },
                    { 170, "fr-frc", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9203), "Cajun French", "Français Cadien", null },
                    { 171, "fr-old", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9216), "Old French", "Ancien français", null },
                    { 172, "fr-qc", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9229), "Quebec French", "Québécois", null },
                    { 173, "frr", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9252), "North Frisian", "Nordfriisk", null },
                    { 174, "fy", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9265), "West Frisian", "Frysk", null },
                    { 175, "fur", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9277), "Friulian", "Furlan", null },
                    { 176, "ga", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9288), "Irish Gaelic", "Gaeilge", null },
                    { 177, "gv", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9300), "Manx", "Gaelg", null },
                    { 178, "gag", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9312), "Gagauz", "Gagauz dili", null },
                    { 179, "gd", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9324), "Scottish Gaelic", "Gàidhlig", null },
                    { 180, "gan-hans", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9335), "Gan Chinese [Simplified script]", "赣语", null },
                    { 181, "gan-hant", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9349), "Gan Chinese [Traditional script]", "赣語", null },
                    { 182, "gl", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9362), "Galician", "Galego", null },
                    { 183, "gez", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9373), "Ge’ez", "ግዕዝ", null },
                    { 184, "glk", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9387), "Gilaki", "گیلکی", null },
                    { 185, "gdo", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9399), "Godoberi", "ГъибдилIи мицци", null },
                    { 186, "sga", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9413), "Old Irish", "Goídelc", null },
                    { 187, "huz", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9425), "Hunzib ", "гьонкьос мыц", null },
                    { 188, "grn", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9438), "Guarani", "Guaraní", null },
                    { 189, "got", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9450), "Gothic", "Gutiska", null },
                    { 190, "gu", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9462), "Gujarati", "ગુજરાતી", null },
                    { 191, "zhc", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9474), "Classical Chinese", "文言文", null },
                    { 192, "ha-latn", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9487), "Hausa [Latin script]", "Hausa", null },
                    { 193, "ha-arab", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9499), "Hausa [Arabic script]", "هَوُس", null },
                    { 194, "zh-hans", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9511), "Mandarin Chinese [Simplified script]", "汉语", null },
                    { 195, "zh-hant", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9524), "Mandarin Chinese [Traditional Script]", "漢語", null },
                    { 196, "yue-hans", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9536), "Cantonese [Simplified script]", "粤语", null },
                    { 197, "yue-hant", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9548), "Cantonese [Traditional script]", "粵語", null },
                    { 198, "hak-hans", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9561), "Hakka [Simplified script]", "客家话", null },
                    { 199, "hak-hant", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9573), "Hakka [Traditional script]", "客家語", null },
                    { 200, "hsn-hans", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9585), "Xiang Chinese [Simplified script]", "湘语", null },
                    { 201, "hsn-hant", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9597), "Xiang Chinese [Traditional script]", "湘語", null },
                    { 202, "czh-hans", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9609), "Hui [Simplified script]", "徽语", null },
                    { 203, "czh-hant", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9621), "Hui [Traditional script]", "徽語", null },
                    { 204, "nan-hans", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9633), "Minnan Chinese [Simplified script]", "闽南语", null },
                    { 205, "nan-hant", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9645), "Minnan Chinese [Traditional script]", "閩南語", null },
                    { 206, "cdo-hans", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9657), "Mindong Chinese [Simplified script]", "闽东语", null },
                    { 207, "cdo-hant", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9669), "Mindong Chinese [Traditional script]", "閩東語", null },
                    { 208, "ko", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9681), "Korean", "한국어", null },
                    { 209, "ko-mid", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9692), "Middle Korean", "중세한국어", null },
                    { 210, "xal", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9705), "Kalmyk", "Хальмг келн", null },
                    { 211, "haw", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9717), "Hawaiian", "`Ōlelo Hawai`i", null },
                    { 212, "hy", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9741), "Armenian", "Հայերեն", null },
                    { 213, "hy-e", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9753), "Armenian, Eastern", "արևելահայերեն", null },
                    { 214, "hy-w", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9766), "Armenian, Western", "Արեւմտահայերէն", null },
                    { 215, "hy-h", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9779), "Armenian, Homshetsi", "Հոմշեցի", null },
                    { 216, "hy-mid", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9792), "Middle Armenian", "միջին հայերեն", null },
                    { 217, "hy-clas", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9804), "Classical Armenian", "գրաբար", null },
                    { 218, "grc", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9817), "Greek, ancient", "Ἑλληνική", null },
                    { 219, "hif", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9830), "Fiji Hindi", "Fiji Baat", null },
                    { 220, "hi", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9842), "Hindi", "हिन्दी", null },
                    { 221, "gin", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9855), "Hinukh", "гьинузас мец", null },
                    { 222, "arp", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9867), "Arapaho", "Hinóno'eitíít", null },
                    { 223, "ho", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9880), "Hiri Motu", "Hiri Motu", null },
                    { 224, "hit", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9892), "Hittite", "nešili", null },
                    { 225, "hmn", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9904), "Hmong", "Hmoob", null },
                    { 226, "hop", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9916), "Hopi", "Hopilavayi", null },
                    { 227, "hsb", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9928), "Sorbian (upper)", "Hornjoserbšćina", null },
                    { 228, "inh", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9941), "Ingush", "гӀалгӀайн мотт", null },
                    { 229, "jv", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9954), "Javanese", "Basa Jawa", null },
                    { 230, "jv-bms", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9965), "Banyumasan", "Basa Banyumasan", null },
                    { 231, "hr", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9977), "Croatian", "Hrvatski", null },
                    { 232, "hur", new DateTime(2024, 1, 14, 14, 15, 9, 839, DateTimeKind.Utc).AddTicks(9989), "Halkomelem", "Hul'q'umín'um'", null },
                    { 233, "rw", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2), "Kinyarwanda", "Ikinyarwanda", null },
                    { 234, "iu", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(13), "Inuktitut", "ᐃᓄᒃᑎᑐᑦ", null },
                    { 235, "ipk", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(26), "Iñupiaq", "Iñupiatun", null },
                    { 236, "id", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(39), "Indonesian", "Bahasa Indonesia", null },
                    { 237, "ig", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(51), "Igbo", "Igbo", null },
                    { 238, "is", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(63), "Icelandic", "Íslenska", null },
                    { 239, "it", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(75), "Italian", "Italiano", null },
                    { 240, "itl", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(87), "Itelmen", "итэнмэн", null },
                    { 241, "he", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(99), "Hebrew", "עברית", null },
                    { 242, "he-hbo", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(110), "Hebrew, Biblical", "עברית מקראית", null },
                    { 243, "jmk", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(123), "Jamtlandic", "Jamtsk", null },
                    { 244, "kry", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(134), "Kryts", "Jek", null },
                    { 245, "cu", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(146), "Old Church Slavonic", "Ѩзыкъ словѣньскъ", null },
                    { 246, "cjy-hans", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(159), "Jin Chinese [Simplified script]", "晋语", null },
                    { 247, "cjy-hant", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(172), "Jin Chinese [Traditional script]", "晉語", null },
                    { 248, "ka", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(184), "Georgian", "ქართული", null },
                    { 249, "ka-old", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(197), "Old Georgian", "ენაჲ ქართული", null },
                    { 250, "kjj", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(210), "Khinalug", "каьтш мицI", null },
                    { 251, "kab", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(223), "Kabyle", "Taqbaylit", null },
                    { 252, "mh", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(245), "Marshallese", "Kajin M̧ajeļ", null },
                    { 253, "kl", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(259), "Greenlandic", "Kalaallisut", null },
                    { 254, "mwp", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(271), "Kala Lagaw Ya", "Kala Lagaw Ya", null },
                    { 255, "moh", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(282), "Mohawk", "Kanien’kéha", null },
                    { 256, "kn", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(296), "Kannada", "ಕನ್ನಡ", null },
                    { 257, "cak", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(309), "Kaqchikel Mayan", "Kaqchikel Ch'ab'äl", null },
                    { 258, "kdr", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(326), "Karaim", "Karaj tili", null },
                    { 259, "kpt", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(338), "Karata", "Karata", null },
                    { 260, "kar", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(350), "Karen", "Karen", null },
                    { 261, "krl", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(361), "Karelian", "Karjala", null },
                    { 262, "csb", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(373), "Kashubian", "Kaszëbsczi", null },
                    { 263, "gbb", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(385), "Kaytetye", "Kaytetye", null },
                    { 264, "ks-deva", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(397), "Kashmiri [Devanagari script]", "कश्मीरी", null },
                    { 265, "ks-arab", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(410), "Kashmiri [Arabic script]", "كشميري", null },
                    { 266, "kk", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(423), "Kazakh", "қазақша", null },
                    { 267, "km", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(435), "Khmer", "ខ្មែរ", null },
                    { 268, "kw", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(447), "Cornish", "Kernewek", null },
                    { 269, "khi", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(459), "Khoisan", "Khoisan", null },
                    { 270, "kca", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(470), "Khanty", "хӑнты ясӑӈ", null },
                    { 271, "khv", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(483), "Khwarshi", "Khwarshi", null },
                    { 272, "krc", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(494), "Karachay-Balkar", "Къарачай-Малкъар тил", null },
                    { 273, "ky", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(520), "Kyrgyz", "Кыргызча", null },
                    { 274, "gil", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(532), "Gilbertese", "Kiribati", null },
                    { 275, "rn", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(543), "Ikirundi", "Kirundi", null },
                    { 276, "sw", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(555), "Swahili", "Kiswahili", null },
                    { 277, "kv", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(566), "Komi", "Коми кыв", null },
                    { 278, "kv-koi", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(578), "Komi-Permyak", "Komi-Permyak", null },
                    { 279, "kv-kpv", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(590), "Komi-Zyrian", "Komi-Zyrian", null },
                    { 280, "kmk", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(602), "Konkani", "ಕಒಂಕಣಇ", null },
                    { 281, "ht", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(614), "Haitian Creole", "Krèyol", null },
                    { 282, "kea", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(627), "Cape Verdean Creole", "Kriólu Kabuberdiánu", null },
                    { 283, "ani", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(640), "Andi", "къIaваннаб мицци", null },
                    { 284, "ksk", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(653), "Kumyk", "Къумукъ тил", null },
                    { 285, "ku-latn", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(666), "Kurdish [Latin script]", "Kurmancî", null },
                    { 286, "ku-arab", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(679), "Kurdish [Arabic script]", "كوردي", null },
                    { 287, "kgg", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(691), "Kusunda", "Kusunda", null },
                    { 288, "kwk", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(702), "Kwak'wala", "Kwak'wala", null },
                    { 289, "lkt", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(714), "Lakota", "Lakȟótiyapi", null },
                    { 290, "las", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(727), "Lama", "Lamba", null },
                    { 291, "ltg", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(738), "Latgalian", "Latgaļu", null },
                    { 292, "lo", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(750), "Lao", "ພງສງລງວ", null },
                    { 293, "lzz", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(762), "Laz", "ლაზური", null },
                    { 294, "la", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(774), "Latin", "lingua latīna", null },
                    { 295, "la-va", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(787), "Ecclesiastical Latin", "Lingua Latina Ecclesiastica", null },
                    { 296, "sm", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(800), "Samoan", "le gagana Samoa", null },
                    { 297, "lez", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(811), "Lezgian", "Лезги чIал", null },
                    { 298, "liv", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(824), "Livonian", "Līvõ kēļ", null },
                    { 299, "lld", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(837), "Ladin", "ladin", null },
                    { 300, "lv", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(849), "Latvian", "Latviešu", null },
                    { 301, "unm", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(861), "Delaware", "Lenape", null },
                    { 302, "lb", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(872), "Luxembourgish", "Lëtzebuergesch", null },
                    { 303, "lbe", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(885), "Lak", "лакку маз", null },
                    { 304, "lt", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(897), "Lithuanian", "Lietuvių", null },
                    { 305, "lij", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(909), "Ligurian", "lìgure", null },
                    { 306, "lim", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(922), "Limburgish", "Limburgs", null },
                    { 307, "ln", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(933), "Lingala", "Lingála", null },
                    { 308, "loz", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(945), "Lozi", "Lozi", null },
                    { 309, "ckt", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(956), "Chukchi", "Ԓыгъоравэтԓьэн йиԓыйиԓ", null },
                    { 310, "lud", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(970), "Ludic", "lyydin kiel'", null },
                    { 311, "lmo", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(982), "Lombard", "lumbaart", null },
                    { 312, "sva", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(993), "Svan", "ლუშნუ ნინ", null },
                    { 313, "mas", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1006), "Maasai", "ɔl Maa", null },
                    { 314, "yua", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1031), "Yucatec Maya", "Maaya t'aan", null },
                    { 315, "mdh", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1043), "Maguindanao", "Maguindanao", null },
                    { 316, "hu", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1055), "Hungarian", "Magyar", null },
                    { 317, "mkz", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1067), "Makasae", "Makassai", null },
                    { 318, "mk", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1077), "Macedonian", "Македонски", null },
                    { 319, "mg", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1090), "Malagasy", "Malagasy", null },
                    { 320, "ml", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1101), "Malayalam", "മലയാളം", null },
                    { 321, "mt", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1114), "Maltese", "Malti", null },
                    { 322, "mnc", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1125), "Manchu", "Manju gisun", null },
                    { 323, "mns", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1137), "Mansi", "Маньси", null },
                    { 324, "xmf", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1149), "Mingrelian", "მარგალური ნინა", null },
                    { 325, "mr", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1163), "Marathi", "मराठी", null },
                    { 326, "mic", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1175), "Micmac", "Míkmaq", null },
                    { 327, "mwl", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1187), "Mirandese", "Mirandés", null },
                    { 328, "mo", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1200), "Moldovan", "Moldovenească", null },
                    { 329, "mdf", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1213), "Moksha", "Мокшень", null },
                    { 330, "mnw", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1225), "Mon", "Mon", null },
                    { 331, "mn", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1236), "Mongolian", "Монгол хэл", null },
                    { 332, "cmg", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1249), "Classical Mongolian", "Mongɣol kele", null },
                    { 333, "arn", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1261), "Mapuche", "Mapudungun", null },
                    { 334, "mfe", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1272), "Mauritian", "Morisyen", null },
                    { 335, "mof", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1284), "Mohegan", "Moyahikaniw", null },
                    { 336, "mia", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1295), "Miami-Illinois", "Myaamia", null },
                    { 337, "rut", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1307), "Rutul", "мыхIабишды чIел", null },
                    { 338, "mhr", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1321), "Mari (Meadow)", "Олык марий йылме", null },
                    { 339, "mus", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1334), "Creek", "Mvskoke", null },
                    { 340, "mrj", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1346), "Mari (Hill)", "Кырык мары йӹлмӹ", null },
                    { 341, "my", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1360), "Burmese", "မ္ရန္မာ", null },
                    { 342, "nah", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1373), "Nahuatl", "Náhuatl", null },
                    { 343, "na", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1385), "Nauruan", "dorerin Naoero", null },
                    { 344, "nap", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1396), "Neapolitan", "Napulitano", null },
                    { 345, "new", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1408), "Nepal Bhasa", "नेपाल भाषा", null },
                    { 346, "ppl", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1422), "Pipil", "Nawat", null },
                    { 347, "yrk", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1433), "Nenets", "Ненэця\" вада", null },
                    { 348, "aii", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1457), "Neo-Aramaic", "Neo-Aramaic", null },
                    { 349, "nll", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1471), "Nihali", "Nahali", null },
                    { 350, "niv", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1482), "Nivkh", "Нивхгу диф", null },
                    { 351, "nio", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1494), "Nganasan", "Ня’’ сиәде", null },
                    { 352, "niu", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1508), "Niuean", "ko e vagahau Niuē", null },
                    { 353, "nog", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1521), "Nogai", "Ногай тили", null },
                    { 354, "cr", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1534), "Cree", "ᓂᐦᔭᐘᒃ", null },
                    { 355, "ja", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1557), "Japanese", "日本語", null },
                    { 356, "ja-clas", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1569), "Classical Japanese", "和文", null },
                    { 357, "nd", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1582), "Ndebele, Northern", "isiNdebele", null },
                    { 358, "nl", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1594), "Dutch", "Nederlands", null },
                    { 359, "nl-nbr", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1605), "Dutch, Brabantian", "Braobans", null },
                    { 360, "nl-be", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1617), "Flemish", "Vlaams", null },
                    { 361, "nl-mid", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1628), "Middelnederlands", "Middelnederlands", null },
                    { 362, "ne", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1640), "Nepali", "नेपाली", null },
                    { 363, "pih", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1652), "Norfuk/Pitkern", "Norfuk/Pitkern", null },
                    { 364, "no", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1664), "Norwegian", "Norsk", null },
                    { 365, "no-nn", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1676), "Norwegian, Nynorsk", "Nynorsk", null },
                    { 366, "no-nb", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1688), "Norwegian, Bokmål", "Bokmål", null },
                    { 367, "no-val", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1702), "Norwegian, Vallemål", "Vallemål", null },
                    { 368, "non", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1715), "Old Norse", "Norrœnt", null },
                    { 369, "ntj", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1727), "Ngaanyatjarra", "Ngaanyatjarra", null },
                    { 370, "nr", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1739), "Ndebele, Southern", "Nrebele", null },
                    { 371, "oka", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1751), "Colville-Okanagan Salish", "Nsəlxcin", null },
                    { 372, "ny", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1764), "Chewa", "Nyanja", null },
                    { 373, "kpy", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1775), "Koryak", "нымылан", null },
                    { 374, "oc", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1787), "Occitan", "Occitan", null },
                    { 375, "ryu", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1799), "Okinawan", "ウチナーグチ", null },
                    { 376, "olo", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1811), "Livvi-Karelian", "Olonets", null },
                    { 377, "one", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1823), "Oneida", "Onʌyotaʔa:ka", null },
                    { 378, "ood", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1837), "O’odham", "Oʼodham ñiok", null },
                    { 379, "or", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1851), "Oriya", "ଓଡ଼ିଆ", null },
                    { 380, "om", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1864), "Oromoo", "Oromoo", null },
                    { 381, "hz", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1875), "Herero", "Otjiherero", null },
                    { 382, "os", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1887), "Ossetic, Iron", "Ирон", null },
                    { 383, "os-digor", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1899), "Ossetic, Digor", "дигорон", null },
                    { 384, "pi", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1911), "Pali", "पाळि", null },
                    { 385, "pa-guru", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1923), "Punjabi [Gurmukhi script]", "ਪੰਜਾਬੀ", null },
                    { 386, "pa-deva", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1935), "Punjabi [Devanagari script]", "पंजाबी", null },
                    { 387, "pa-arab", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1948), "Punjabi [Arabic script]", "پنجابي", null },
                    { 388, "pau", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1960), "Palauan", "Palauan", null },
                    { 389, "pap", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1972), "Papiamento", "Papiamentu", null },
                    { 390, "prk", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1984), "Wa", "Parauk", null },
                    { 391, "pam", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(1996), "Kapampangan", "Pampangan", null },
                    { 392, "paa", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2007), "Papuan", "Papuan", null },
                    { 393, "nds", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2019), "Low Saxon", "Plattdüütsch", null },
                    { 394, "pdt", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2032), "Plautdietsch", "Plautdietsch", null },
                    { 395, "pl", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2054), "Polish", "Polski", null },
                    { 396, "pt", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2066), "Portuguese", "Português", null },
                    { 397, "pt-pt", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2078), "European Portuguese", "Português de Portugal", null },
                    { 398, "pt-br", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2091), "Brazilian Portuguese", "Português do Brasil", null },
                    { 399, "prg", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2104), "Prussian", "Prūsiskan", null },
                    { 400, "ps", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2116), "Pashto", "پښتو", null },
                    { 401, "phn", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2128), "Phoenician", "Phoenician", null },
                    { 402, "pms", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2139), "Piedmontese", "piemontèis", null },
                    { 403, "piu", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2152), "Pintupi-Luritja", "Pintupi-Luritja", null },
                    { 404, "pjt", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2164), "Pitjantjatjara", "Pitjantjatjara", null },
                    { 405, "kaa", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2177), "Karakalpak", "Qaraqalpaq tili", null },
                    { 406, "crh", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2189), "Crimean Tatar", "Qırımtatar tili", null },
                    { 407, "qu", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2203), "Quechua", "Runa simi", null },
                    { 408, "rap", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2214), "Rapa Nui", "Rapa Nui", null },
                    { 409, "ro", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2226), "Romanian", "Română", null },
                    { 410, "rgn", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2238), "Romagnol", "Romagnòl", null },
                    { 411, "rom-latn", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2249), "Romany [Latin script]", "Romani", null },
                    { 412, "rom-cyrl", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2262), "Romany [Cyrillic script]", "Романи", null },
                    { 413, "roo", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2274), "Rotokas", "Rotokas", null },
                    { 414, "rtm", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2285), "Rotuman", "Fäeag Rotuma", null },
                    { 415, "rm", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2298), "Romansh", "Rumantsch", null },
                    { 416, "rue", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2309), "Rusyn", "Rusyn", null },
                    { 417, "rue-rs", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2321), "Pannonian Rusyn", "Бачваньски руски язик", null },
                    { 418, "ru", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2334), "Russian", "Русский", null },
                    { 419, "sg", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2345), "Sango", "Sängö", null },
                    { 420, "ari", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2358), "Arikara", "Sániš", null },
                    { 421, "sa", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2370), "Sanskrit", "संस्कृत", null },
                    { 422, "sc", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2382), "Sardinian", "Sardu", null },
                    { 423, "sah", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2394), "Yakut", "Саха тыла", null },
                    { 424, "sco", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2406), "Scots", "Scoats", null },
                    { 425, "shs", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2417), "Shuswap", "Secwepemctsín", null },
                    { 426, "fla", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2430), "Montana Salish", "Séliš", null },
                    { 427, "shn", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2441), "Shan", "Shan", null },
                    { 428, "scn", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2453), "Sicilian", "Sicilianu", null },
                    { 429, "scn-tara", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2465), "Tarantino", "Tarandíne", null },
                    { 430, "sml", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2477), "Sinama, Central", "Sinama, Central", null },
                    { 431, "sog", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2489), "Sogdian", "Sogdian", null },
                    { 432, "ckb", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2501), "Soranî", "سۆرانی", null },
                    { 433, "shh", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2513), "Shoshoni", "Sosoni’da̲i̲gwape", null },
                    { 434, "sr-cyrl", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2528), "Serbian [Cyrillic script]", "Српски", null },
                    { 435, "sr-latn", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2540), "Serbian [Latin script]", "Srpski", null },
                    { 436, "sh", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2562), "Serbo-Croatian", "srpskohrvatski", null },
                    { 437, "srn", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2575), "Sranan Tongo", "Sranantogo", null },
                    { 438, "sq", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2586), "Albanian", "Shqipe", null },
                    { 439, "ii", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2598), "Yi", "ꆇꉙ", null },
                    { 440, "za", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2610), "Zhuang", "Saw cuəŋ", null },
                    { 441, "smi", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2622), "Sami", "Sámi", null },
                    { 442, "smi-smn", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2635), "Inari Sami", "anarâškielâ", null },
                    { 443, "smi-smk", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2648), "Kildin Sami", "самь кӣлл", null },
                    { 444, "smi-smj", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2660), "Lule Sami", "julevsábme", null },
                    { 445, "smi-sme", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2673), "Northern Sami", "davvisámegiella", null },
                    { 446, "smi-smp", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2686), "Pite Sami", "biđonsámegiella", null },
                    { 447, "smi-sms", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2699), "Skolt Sami", "sääˊmǩiõll", null },
                    { 448, "smi-sma", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2712), "Southern Sami", "åarjelsaemien gïele", null },
                    { 449, "smi-smt", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2727), "Ter Sami", "saa´mekiill", null },
                    { 450, "smi-smu", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2739), "Ume Sami", "ubmisámegiella", null },
                    { 451, "sd-deva", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2752), "Sindhi [Devanagari script]", "सनिध", null },
                    { 452, "sd-arab", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2764), "Sindhi [Arabic script]", "سنڗي", null },
                    { 453, "crs", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2777), "Seychellois Creole", "Seselwa", null },
                    { 454, "si", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2789), "Sinhalese", "සිංහල", null },
                    { 455, "den", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2801), "Slavey", "Slavey", null },
                    { 456, "sk", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2812), "Slovak", "Slovenčina", null },
                    { 457, "sl", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2824), "Slovene", "Slovenščina", null },
                    { 458, "szl", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2837), "Silesian", "Ślůnski", null },
                    { 459, "crd", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2849), "Coeur d'Alene Salish", "Snchitsuʼumshtsn", null },
                    { 460, "so", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2862), "Somali", "Soomaali", null },
                    { 461, "st", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2874), "Sotho", "seSotho", null },
                    { 462, "stq", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2885), "Saterland Frisian", "Seeltersk", null },
                    { 463, "ss", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2897), "Swati", "siSwati", null },
                    { 464, "su", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2909), "Sundanese", "Bahasa Sunda", null },
                    { 465, "fi", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2921), "Finnish", "Suomi", null },
                    { 466, "sgn", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2932), "Sign language", "Sign language", null },
                    { 467, "sgn-au", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2944), "Auslan", "Auslan", null },
                    { 468, "sgn-us", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2955), "American Sign Language", "American Sign Language", null },
                    { 469, "sgn-gb", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2967), "British Sign Language", "British Sign Language", null },
                    { 470, "sgn-ee", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2980), "Estonian Sign Language", "Estonian Sign Language", null },
                    { 471, "sgn-cy", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(2992), "Cyprus Sign Language", "Κυπριακή Νοηματική Γλώσσα", null },
                    { 472, "sgn-gr", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3006), "Greek Sign Language", "GSL", null },
                    { 473, "sgn-ie", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3018), "Irish Sign Language", "Irish Sign Language", null },
                    { 474, "sgn-cn", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3030), "Chinese Sign Language", "中国手语", null },
                    { 475, "sgn-de", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3052), "German Sign Language", "DGS", null },
                    { 476, "sgn-fr", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3064), "French Sign Language", "LSF", null },
                    { 477, "sgn-ca-qc", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3076), "Sign language", "LSQ", null },
                    { 478, "sgn-es", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3087), "Spanish Sign Language", "LSE", null },
                    { 479, "sgn-br", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3098), "Brazilian Sign Language", "LIBRAS", null },
                    { 480, "sgn-it", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3110), "Italian Sign Language", "LIS", null },
                    { 481, "sgn-nl", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3121), "Dutch Sign Language", "NGT", null },
                    { 482, "sgn-jp", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3133), "Japanese Sign Language", "日本手話", null },
                    { 483, "sgn-no", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3145), "Norwegian Sign Language", "NSL", null },
                    { 484, "sgn-ru", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3157), "Russian Sign Language", "РЖЯ", null },
                    { 485, "sgn-rs", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3169), "Serbian Sign Language", "Српски знаковни језик", null },
                    { 486, "sgn-il", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3183), "Israeli Sign Language", "שפת סימנים ישראלית", null },
                    { 487, "sgn-se", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3196), "Swedish Sign Language", "TSP", null },
                    { 488, "sv", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3207), "Swedish", "Svenska", null },
                    { 489, "sv-fi", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3219), "Finland Swedish", "Finlandssvenska", null },
                    { 490, "syc", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3231), "Syriac", "ܣܘܪܝܝܐ", null },
                    { 491, "ta", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3243), "Tamil", "தமிழ்", null },
                    { 492, "ta-lk", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3255), "Tamil, Sri Lankan", "தமிழ் (இலங்கை)", null },
                    { 493, "tl", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3270), "Tagalog", "Tagalog", null },
                    { 494, "ttt", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3281), "Tat", "Tati", null },
                    { 495, "tet", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3292), "Tetum", "Tetun", null },
                    { 496, "to", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3303), "Tongan", "lea faka-Tonga", null },
                    { 497, "th", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3315), "Thai", "ภาษาไทย", null },
                    { 498, "tfn", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3327), "Dena'ina", "Dena’ina qenaga", null },
                    { 499, "tpi", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3340), "Tok Pisin", "Tok Pisin", null },
                    { 500, "tab", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3352), "Tabasaran", "табасаран чIал", null },
                    { 501, "taq", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3365), "Tamasheq", "Tamasheq", null },
                    { 502, "ber", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3377), "Berber", "Berber", null },
                    { 503, "tzm", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3389), "Central Atlas Tamazight", "ⵜⴰⵎⴰⵣⵉⵖⵜ", null },
                    { 504, "tly", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3403), "Talysh", "تالشی زَوُن", null },
                    { 505, "tt", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3415), "Tatar", "Татарча", null },
                    { 506, "tsg", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3427), "Tausug", "Bahasa Sūg", null },
                    { 507, "tkr", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3440), "Tsakhur", "цӀаӀхна миз", null },
                    { 508, "tiw", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3452), "Tiwi", "Tiwi", null },
                    { 509, "dgr", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3463), "Dogrib", "Tłı̨chǫ Yatıì", null },
                    { 510, "chy", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3477), "Cheyenne", "Tsétsêhéstâhese", null },
                    { 511, "tn", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3491), "Tswana", "seTswana", null },
                    { 512, "mi", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3502), "Maori", "Reo Māori", null },
                    { 513, "rar", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3514), "Cook Islands Māori", "Māori Kūki 'Āirani", null },
                    { 514, "ty", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3545), "Tahitian", "Reo Mā'ohi", null },
                    { 515, "te", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3559), "Telugu", "తెలుగు", null },
                    { 516, "din", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3583), "Dinka", "Thuɔŋjäŋ", null },
                    { 517, "vi", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3597), "Vietnamese", "Tiếng Việt", null },
                    { 518, "tin", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3611), "Tindi", "Tindi", null },
                    { 519, "tlh", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3622), "Klingon", "tlhIngan-Hol", null },
                    { 520, "tli", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3634), "Tlingit", "Lingít", null },
                    { 521, "ti", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3646), "Tigrinya", "ትግርኛ", null },
                    { 522, "ddo", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3658), "Tsez", "Цезйас мец", null },
                    { 523, "ve", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3670), "Venda", "tshiVenda", null },
                    { 524, "tr", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3682), "Turkish", "Türkçe", null },
                    { 525, "ota", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3695), "Ottoman Turkish", "عثمانلیجہ", null },
                    { 526, "tk", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3707), "Turkmen", "Türkmençe", null },
                    { 527, "tyv", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3720), "Tuvan", "Тыва дыл", null },
                    { 528, "uby", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3733), "Ubykh", "tʷaχəbza", null },
                    { 529, "twi", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3746), "Twi", "Twi", null },
                    { 530, "cim", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3757), "Cimbrian", "Tzimbris", null },
                    { 531, "udm", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3770), "Udmurt", "Удмурт кыл", null },
                    { 532, "uga", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3782), "Ugaritic", "Ugaritic", null },
                    { 533, "ale", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3794), "Aleut", "Unangam Tunuu", null },
                    { 534, "udi", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3805), "Udi", "удин муз", null },
                    { 535, "udi-old", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3818), "Old Udi", "Old Udi", null },
                    { 536, "uk", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3829), "Ukrainian", "Українська", null },
                    { 537, "ur", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3841), "Urdu", "اُردو", null },
                    { 538, "ug", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3853), "Uyghur", "ﺋۇيغۇر", null },
                    { 539, "uz", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3866), "Uzbek", "O'zbekcha", null },
                    { 540, "vai", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3878), "Vai", "Vai", null },
                    { 541, "vot", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3889), "Votic", "vađđa ceeli", null },
                    { 542, "vec", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3902), "Venetian", "vèneto", null },
                    { 543, "vro", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3914), "Voro", "Võro kiil", null },
                    { 544, "vep", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3926), "Veps", "Vepsän kel'", null },
                    { 545, "wa", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3938), "Walloon", "Walon", null },
                    { 546, "wbp", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3950), "Warlpiri", "Warlpiri", null },
                    { 547, "wrm", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3962), "Warumungu", "Warumungu", null },
                    { 548, "wac", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3973), "Wasco-Wishram", "Wasco-Wishram", null },
                    { 549, "was", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3985), "Washo", "Washo", null },
                    { 550, "pnb", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(3996), "Western Panjabi", "پنجابی", null },
                    { 551, "war", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4008), "Waray-Waray", "Winaray", null },
                    { 552, "wo", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4020), "Wolof", "Wolof", null },
                    { 553, "wuu-hans", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4032), "Wu Chinese [Simplified script]", "吴语", null },
                    { 554, "wuu-hant", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4045), "Wu Chinese [Traditional script]", "吳語", null },
                    { 555, "myp", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4058), "Pirahã", "xapaitíiso", null },
                    { 556, "ts", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4071), "Tsonga", "xiTsonga", null },
                    { 557, "hai", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4083), "Haida", "X̲aat Kíl", null },
                    { 558, "xh", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4106), "Xhosa", "isiXhosa", null },
                    { 559, "xum", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4118), "Umbrian", "Iuku Umbriu", null },
                    { 560, "ket", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4130), "Ket", "Yenisei Ostyak", null },
                    { 561, "yi", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4142), "Yiddish", "ייִדיש", null },
                    { 562, "yol", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4153), "Yola", "Yola", null },
                    { 563, "yo", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4164), "Yoruba", "Yorùbá", null },
                    { 564, "esu", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4178), "Yup’ik", "Yup’ik", null },
                    { 565, "zza", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4191), "Zazaki", "Zazaki", null },
                    { 566, "zea", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4203), "Zeelandic", "Zeêuws", null },
                    { 567, "sgs", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4215), "Samogitian", "Žemaitėška", null },
                    { 568, "zu", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4228), "Zulu", "isiZulu", null },
                    { 569, "zun", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4240), "Zuni", "Zuni", null },
                    { 570, "art", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4251), "Constructed Language", "Constructed Language", null },
                    { 571, "art-ido", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4263), "Ido", "Ido", null },
                    { 572, "art-ina", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4274), "Interlingua", "Interlingua", null },
                    { 573, "art-jbo", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4286), "Lojban", "Lojban", null },
                    { 574, "art-lfn", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4298), "Lingua Franca Nova", "Lingua Franca Nova", null },
                    { 575, "art-nov", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4310), "Novial", "Novial", null },
                    { 576, "art-sjn", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4321), "Sindarin", "Sindarin", null },
                    { 577, "art-tlh", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4333), "Klingon", "tlhIngan-Hol", null },
                    { 578, "art-tkp", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4344), "Toki Pona", "Toki Pona", null },
                    { 579, "art-qya", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4356), "Quenya", "Quenya", null },
                    { 580, "art-srs", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4367), "Solresol", "Solresol", null },
                    { 581, "art-vo", new DateTime(2024, 1, 14, 14, 15, 9, 840, DateTimeKind.Utc).AddTicks(4378), "Volapuk", "Volapük", null }
                });

            migrationBuilder.InsertData(
                schema: "auth",
                table: "roles",
                columns: new[] { "Id", "CreatedTime", "Type", "UpdatedTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(2313), "Developer", null },
                    { 2, new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(2318), "Admin", null },
                    { 3, new DateTime(2024, 1, 14, 14, 15, 9, 837, DateTimeKind.Utc).AddTicks(2320), "User", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_attachments_MessageId",
                schema: "msg",
                table: "attachments",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_connections_UserFromId",
                schema: "db",
                table: "connections",
                column: "UserFromId");

            migrationBuilder.CreateIndex(
                name: "IX_connections_UserToId",
                schema: "db",
                table: "connections",
                column: "UserToId");

            migrationBuilder.CreateIndex(
                name: "IX_messages_ConversationId",
                schema: "msg",
                table: "messages",
                column: "ConversationId");

            migrationBuilder.CreateIndex(
                name: "IX_messages_SenderId",
                schema: "msg",
                table: "messages",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_refresh_tokens_UserId",
                schema: "auth",
                table: "refresh_tokens",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_social_links_UserId",
                schema: "db",
                table: "social_links",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_user_achievements_AchievementId",
                table: "user_achievements",
                column: "AchievementId");

            migrationBuilder.CreateIndex(
                name: "IX_user_achievements_UserId",
                table: "user_achievements",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_user_achievements_UsersId",
                table: "user_achievements",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_user_conversations_ConversationId",
                schema: "msg",
                table: "user_conversations",
                column: "ConversationId");

            migrationBuilder.CreateIndex(
                name: "IX_user_conversations_ConversationRoleId",
                schema: "msg",
                table: "user_conversations",
                column: "ConversationRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_user_conversations_UserId",
                schema: "msg",
                table: "user_conversations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_user_languages_LanguageId",
                schema: "lrn",
                table: "user_languages",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_user_languages_LevelId",
                schema: "lrn",
                table: "user_languages",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_user_languages_UserId",
                schema: "lrn",
                table: "user_languages",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_user_roles_UserId",
                schema: "auth",
                table: "user_roles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_users_CountryId",
                schema: "auth",
                table: "users",
                column: "CountryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "attachments",
                schema: "msg");

            migrationBuilder.DropTable(
                name: "connections",
                schema: "db");

            migrationBuilder.DropTable(
                name: "refresh_tokens",
                schema: "auth");

            migrationBuilder.DropTable(
                name: "social_links",
                schema: "db");

            migrationBuilder.DropTable(
                name: "user_achievements");

            migrationBuilder.DropTable(
                name: "user_conversations",
                schema: "msg");

            migrationBuilder.DropTable(
                name: "user_languages",
                schema: "lrn");

            migrationBuilder.DropTable(
                name: "user_roles",
                schema: "auth");

            migrationBuilder.DropTable(
                name: "messages",
                schema: "msg");

            migrationBuilder.DropTable(
                name: "achievements",
                schema: "db");

            migrationBuilder.DropTable(
                name: "conversation_roles",
                schema: "msg");

            migrationBuilder.DropTable(
                name: "language_levels",
                schema: "lrn");

            migrationBuilder.DropTable(
                name: "languages",
                schema: "lrn");

            migrationBuilder.DropTable(
                name: "roles",
                schema: "auth");

            migrationBuilder.DropTable(
                name: "conversations",
                schema: "msg");

            migrationBuilder.DropTable(
                name: "users",
                schema: "auth");

            migrationBuilder.DropTable(
                name: "countries",
                schema: "db");
        }
    }
}
