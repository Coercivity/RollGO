using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class meetingEntertainingEntityLink : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LobbySettings",
                keyColumn: "Id",
                keyValue: new Guid("28207ac9-35b4-4737-8f9f-bc92beb48eac"));

            migrationBuilder.DeleteData(
                table: "LobbySettings",
                keyColumn: "Id",
                keyValue: new Guid("2f8ec210-ffd7-4e1e-be07-5c8b045b03bb"));

            migrationBuilder.DeleteData(
                table: "LobbySettings",
                keyColumn: "Id",
                keyValue: new Guid("9ab5bc41-0b1e-4e68-9de7-800ecd71419a"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("2343e924-272b-4114-ba99-2a1f3a8787dc"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("253857ff-39a4-4c4b-a25a-415526bf920a"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("746f4cab-0854-4a76-941f-7aefd2997f87"));

            migrationBuilder.CreateTable(
                name: "MeetingEntertainmentEntityLink",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    MeetingId = table.Column<Guid>(type: "uuid", nullable: false),
                    EntertainmentEntityId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetingEntertainmentEntityLink", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MeetingEntertainmentEntityLink_EntertainmentEntities_Entert~",
                        column: x => x.EntertainmentEntityId,
                        principalTable: "EntertainmentEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MeetingEntertainmentEntityLink_Meeting_MeetingId",
                        column: x => x.MeetingId,
                        principalTable: "Meeting",
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
                name: "IX_MeetingEntertainmentEntityLink_EntertainmentEntityId",
                table: "MeetingEntertainmentEntityLink",
                column: "EntertainmentEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_MeetingEntertainmentEntityLink_MeetingId",
                table: "MeetingEntertainmentEntityLink",
                column: "MeetingId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MeetingEntertainmentEntityLink");

            migrationBuilder.DeleteData(
                table: "LobbySettings",
                keyColumn: "Id",
                keyValue: new Guid("141b19ef-e7b5-44df-a74f-016e4f9d003f"));

            migrationBuilder.DeleteData(
                table: "LobbySettings",
                keyColumn: "Id",
                keyValue: new Guid("5828d6cf-ae3a-4a24-a2d2-7d661ed8d31c"));

            migrationBuilder.DeleteData(
                table: "LobbySettings",
                keyColumn: "Id",
                keyValue: new Guid("804ddd35-8a97-4a52-8b92-ec077dbe49cf"));

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

            migrationBuilder.InsertData(
                table: "Lobby",
                columns: new[] { "Id", "AdminId", "CreatedDateTime", "Name" },
                values: new object[,]
                {
                    { new Guid("2343e924-272b-4114-ba99-2a1f3a8787dc"), new Guid("2b634477-5420-42ed-bf11-eb5c04cd48f2"), new DateTime(2024, 1, 21, 15, 32, 14, 845, DateTimeKind.Utc).AddTicks(3662), "@mogu$" },
                    { new Guid("253857ff-39a4-4c4b-a25a-415526bf920a"), new Guid("a152a4ae-0634-471e-a966-4413d3b3a6f0"), new DateTime(2024, 1, 21, 15, 32, 14, 845, DateTimeKind.Utc).AddTicks(3635), "tatapuchi" },
                    { new Guid("746f4cab-0854-4a76-941f-7aefd2997f87"), new Guid("51d9a091-8a0c-4df7-a307-a5f1bbbe8e2c"), new DateTime(2024, 1, 21, 15, 32, 14, 845, DateTimeKind.Utc).AddTicks(3685), "ch33bs" }
                });

            migrationBuilder.InsertData(
                table: "LobbySettings",
                columns: new[] { "Id", "CreatedDateTime", "LobbyId", "MinimalRating", "MoviesPerUser", "WithKoefficient" },
                values: new object[,]
                {
                    { new Guid("28207ac9-35b4-4737-8f9f-bc92beb48eac"), new DateTime(2024, 1, 21, 15, 32, 14, 845, DateTimeKind.Utc).AddTicks(3748), new Guid("2343e924-272b-4114-ba99-2a1f3a8787dc"), 7.5f, 2, true },
                    { new Guid("2f8ec210-ffd7-4e1e-be07-5c8b045b03bb"), new DateTime(2024, 1, 21, 15, 32, 14, 845, DateTimeKind.Utc).AddTicks(3750), new Guid("746f4cab-0854-4a76-941f-7aefd2997f87"), 7.5f, 2, true },
                    { new Guid("9ab5bc41-0b1e-4e68-9de7-800ecd71419a"), new DateTime(2024, 1, 21, 15, 32, 14, 845, DateTimeKind.Utc).AddTicks(3744), new Guid("253857ff-39a4-4c4b-a25a-415526bf920a"), 7.5f, 2, true }
                });
        }
    }
}
