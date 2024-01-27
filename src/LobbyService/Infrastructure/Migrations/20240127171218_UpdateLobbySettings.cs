using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateLobbySettings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LobbySettings");

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("5cebbed6-094f-4833-a31a-ca8b26d1c2fa"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("66a0e7a9-bc5e-4086-b37c-1d571338931b"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("d11f731a-c3c1-4864-91a4-71bd6deec3cb"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "MeetingEntertainmentEntityLink",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<double>(
                name: "MinimalRating",
                table: "Lobby",
                type: "double precision",
                nullable: false,
                defaultValue: 1.0);

            migrationBuilder.AddColumn<int>(
                name: "MoviesPerUser",
                table: "Lobby",
                type: "integer",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AddColumn<bool>(
                name: "WithCoefficient",
                table: "Lobby",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Lobby",
                columns: new[] { "Id", "AdminId", "CreatedDateTime", "MinimalRating", "MoviesPerUser", "Name", "WithCoefficient" },
                values: new object[,]
                {
                    { new Guid("69574a7a-7901-4276-82cb-db9fef200ac1"), new Guid("3289df17-e89a-41ec-bce8-576e5819b7b8"), new DateTime(2024, 1, 27, 17, 12, 17, 880, DateTimeKind.Utc).AddTicks(9688), 7.5, 2, "shu@gg", true },
                    { new Guid("b8b93828-8935-44c2-915a-62eb1dabed64"), new Guid("f6da600e-43c5-4f5c-8a9b-ea24f6324799"), new DateTime(2024, 1, 27, 17, 12, 17, 880, DateTimeKind.Utc).AddTicks(9728), 7.5, 2, "b01b", true },
                    { new Guid("f6a82301-492b-4823-a99e-9cadc170f8bf"), new Guid("6babba78-6b9e-4f2f-83dc-3c2d2a3e6cc0"), new DateTime(2024, 1, 27, 17, 12, 17, 880, DateTimeKind.Utc).AddTicks(9598), 7.5, 2, "13_wacky_dog3", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("69574a7a-7901-4276-82cb-db9fef200ac1"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("b8b93828-8935-44c2-915a-62eb1dabed64"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("f6a82301-492b-4823-a99e-9cadc170f8bf"));

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "MeetingEntertainmentEntityLink");

            migrationBuilder.DropColumn(
                name: "MinimalRating",
                table: "Lobby");

            migrationBuilder.DropColumn(
                name: "MoviesPerUser",
                table: "Lobby");

            migrationBuilder.DropColumn(
                name: "WithCoefficient",
                table: "Lobby");

            migrationBuilder.CreateTable(
                name: "LobbySettings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    LobbyId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    MinimalRating = table.Column<float>(type: "real", nullable: false),
                    MoviesPerUser = table.Column<int>(type: "integer", nullable: false),
                    WithKoefficient = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LobbySettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LobbySettings_Lobby_LobbyId",
                        column: x => x.LobbyId,
                        principalTable: "Lobby",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Lobby",
                columns: new[] { "Id", "AdminId", "CreatedDateTime", "Name" },
                values: new object[,]
                {
                    { new Guid("5cebbed6-094f-4833-a31a-ca8b26d1c2fa"), new Guid("bb3fba4d-9faa-4860-bfa3-80e9b116da51"), new DateTime(2024, 1, 27, 14, 28, 25, 702, DateTimeKind.Utc).AddTicks(6546), "b0|b" },
                    { new Guid("66a0e7a9-bc5e-4086-b37c-1d571338931b"), new Guid("9fc7fdc8-b278-4c3b-a7fd-41609aa5f7f7"), new DateTime(2024, 1, 27, 14, 28, 25, 702, DateTimeKind.Utc).AddTicks(6494), "$hr0nkma$ter" },
                    { new Guid("d11f731a-c3c1-4864-91a4-71bd6deec3cb"), new Guid("13cf6459-0e86-471f-aa4e-f86b18d4aaa3"), new DateTime(2024, 1, 27, 14, 28, 25, 702, DateTimeKind.Utc).AddTicks(6536), "chungus" }
                });

            migrationBuilder.InsertData(
                table: "LobbySettings",
                columns: new[] { "Id", "CreatedDateTime", "LobbyId", "MinimalRating", "MoviesPerUser", "WithKoefficient" },
                values: new object[,]
                {
                    { new Guid("141b19ef-e7b5-44df-a74f-016e4f9d003f"), new DateTime(2024, 1, 27, 14, 28, 25, 702, DateTimeKind.Utc).AddTicks(6624), new Guid("66a0e7a9-bc5e-4086-b37c-1d571338931b"), 7.5f, 2, true },
                    { new Guid("5828d6cf-ae3a-4a24-a2d2-7d661ed8d31c"), new DateTime(2024, 1, 27, 14, 28, 25, 702, DateTimeKind.Utc).AddTicks(6630), new Guid("5cebbed6-094f-4833-a31a-ca8b26d1c2fa"), 7.5f, 2, true },
                    { new Guid("804ddd35-8a97-4a52-8b92-ec077dbe49cf"), new DateTime(2024, 1, 27, 14, 28, 25, 702, DateTimeKind.Utc).AddTicks(6628), new Guid("d11f731a-c3c1-4864-91a4-71bd6deec3cb"), 7.5f, 2, true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LobbySettings_LobbyId",
                table: "LobbySettings",
                column: "LobbyId",
                unique: true);
        }
    }
}
