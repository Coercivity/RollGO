using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddLobbySettings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meeting_EntertainmentEntity_WinnerEntityId",
                table: "Meeting");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EntertainmentEntity",
                table: "EntertainmentEntity");

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("472d95cc-381a-4d2f-b5eb-3fb282b10920"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("b70bd0bc-7309-46c1-a62f-816f668aad5e"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("e06acd16-ab24-44f7-baa3-1b5d07d73b0c"));

            migrationBuilder.RenameTable(
                name: "EntertainmentEntity",
                newName: "EntertainmentEntities");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EntertainmentEntities",
                table: "EntertainmentEntities",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "LobbySettings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    LobbyId = table.Column<Guid>(type: "uuid", nullable: false),
                    MinimalRating = table.Column<float>(type: "real", nullable: false),
                    MoviesPerUser = table.Column<int>(type: "integer", nullable: false),
                    WithKoefficient = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_LobbySettings_LobbyId",
                table: "LobbySettings",
                column: "LobbyId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Meeting_EntertainmentEntities_WinnerEntityId",
                table: "Meeting",
                column: "WinnerEntityId",
                principalTable: "EntertainmentEntities",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meeting_EntertainmentEntities_WinnerEntityId",
                table: "Meeting");

            migrationBuilder.DropTable(
                name: "LobbySettings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EntertainmentEntities",
                table: "EntertainmentEntities");

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

            migrationBuilder.RenameTable(
                name: "EntertainmentEntities",
                newName: "EntertainmentEntity");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EntertainmentEntity",
                table: "EntertainmentEntity",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Lobby",
                columns: new[] { "Id", "AdminId", "CreatedDateTime", "Name" },
                values: new object[,]
                {
                    { new Guid("472d95cc-381a-4d2f-b5eb-3fb282b10920"), new Guid("d754bb36-659d-4734-81f5-76ab8fe6b69b"), new DateTime(2023, 12, 24, 19, 22, 0, 128, DateTimeKind.Utc).AddTicks(9816), "spark" },
                    { new Guid("b70bd0bc-7309-46c1-a62f-816f668aad5e"), new Guid("3b05d3a6-7445-4f85-a07f-c45a70177647"), new DateTime(2023, 12, 24, 19, 22, 0, 128, DateTimeKind.Utc).AddTicks(9785), "yo_mama" },
                    { new Guid("e06acd16-ab24-44f7-baa3-1b5d07d73b0c"), new Guid("fa4812f1-20e6-4795-be8b-8fe5de551265"), new DateTime(2023, 12, 24, 19, 22, 0, 128, DateTimeKind.Utc).AddTicks(9812), "impostor" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Meeting_EntertainmentEntity_WinnerEntityId",
                table: "Meeting",
                column: "WinnerEntityId",
                principalTable: "EntertainmentEntity",
                principalColumn: "Id");
        }
    }
}
