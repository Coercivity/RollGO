using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addMainMappings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:PostgresExtension:uuid-ossp", ",,");

            migrationBuilder.CreateTable(
                name: "EntertainmentEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    KinopoiskId = table.Column<string>(type: "varchar", nullable: false),
                    ImdbId = table.Column<string>(type: "varchar", nullable: false),
                    NameRu = table.Column<string>(type: "varchar", nullable: false),
                    NameEn = table.Column<string>(type: "varchar", nullable: true),
                    PosterUrl = table.Column<string>(type: "varchar", nullable: true),
                    RatingKinopoisk = table.Column<double>(type: "double precision", nullable: false),
                    RatingImdb = table.Column<double>(type: "double precision", nullable: false),
                    WebUrl = table.Column<string>(type: "varchar", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    FilmLength = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "varchar", nullable: true),
                    ShortDescription = table.Column<string>(type: "varchar", nullable: true),
                    IsSeries = table.Column<bool>(type: "boolean", nullable: false),
                    Genres = table.Column<string[]>(type: "text[]", nullable: true),
                    Countries = table.Column<string[]>(type: "text[]", nullable: true),
                    IS_SERIES = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntertainmentEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lobby",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    Name = table.Column<string>(type: "varchar", nullable: false),
                    AdminId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lobby", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Meeting",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    LobbyId = table.Column<Guid>(type: "uuid", nullable: false),
                    WinnerId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsActive = table.Column<bool>(type: "bool", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meeting", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Meeting_Lobby_LobbyId",
                        column: x => x.LobbyId,
                        principalTable: "Lobby",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserWeight",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    LobbyId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserWeight", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserWeight_Lobby_LobbyId",
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
                    { new Guid("36ce8946-ba8b-4ad1-b161-207415a1fb3d"), new Guid("80251c73-b7ba-47b8-8117-ef8c003c76b8"), new DateTime(2023, 12, 23, 15, 18, 5, 163, DateTimeKind.Utc).AddTicks(3169), "Michelle Wright" },
                    { new Guid("38b63150-e04b-4c02-95f8-169e70d03122"), new Guid("ec9052c5-fd2a-49f1-beef-a9e6f18a24af"), new DateTime(2023, 12, 23, 15, 18, 5, 163, DateTimeKind.Utc).AddTicks(3185), "Lisa Torres" },
                    { new Guid("4200daf6-8a52-4f6b-ba84-2cd0ad9590c8"), new Guid("643f20f5-fef7-4bea-8f82-893598a83bd7"), new DateTime(2023, 12, 23, 15, 18, 5, 163, DateTimeKind.Utc).AddTicks(3180), "Michelle Torres" },
                    { new Guid("47987ac3-3e18-400a-9ee4-78f8e07b589f"), new Guid("cf981b3c-3ae4-48a1-8a8c-addc0d4ff0b9"), new DateTime(2023, 12, 23, 15, 18, 5, 163, DateTimeKind.Utc).AddTicks(3194), "Mateo Lewis" },
                    { new Guid("761b5cb6-ec36-4058-a992-68467b2ae179"), new Guid("bb57cca0-25e9-4eab-a068-8362ec243fe4"), new DateTime(2023, 12, 23, 15, 18, 5, 163, DateTimeKind.Utc).AddTicks(3178), "Mateo Flores" },
                    { new Guid("8370c42c-6f34-485b-a717-6f830a85d080"), new Guid("5f368436-78d6-46df-9046-b68d00b4db0e"), new DateTime(2023, 12, 23, 15, 18, 5, 163, DateTimeKind.Utc).AddTicks(3190), "Sharon Jones" },
                    { new Guid("93662aea-f22d-487c-94fc-db55c37e9415"), new Guid("bfbdee55-53d1-493c-8af3-335dfb1cb5a9"), new DateTime(2023, 12, 23, 15, 18, 5, 163, DateTimeKind.Utc).AddTicks(3199), "Jayden Baker" },
                    { new Guid("9ea5051e-1e71-4e24-8f57-c985a57a6ac2"), new Guid("0b926e47-5292-48cd-bb12-4b0fa8beb65c"), new DateTime(2023, 12, 23, 15, 18, 5, 163, DateTimeKind.Utc).AddTicks(3164), "Elijah Rivera" },
                    { new Guid("bbbcc325-1c9e-419c-975f-c3aaefdf09e9"), new Guid("0e014cd9-5b39-4996-ab2d-fdb9abb2c7c2"), new DateTime(2023, 12, 23, 15, 18, 5, 163, DateTimeKind.Utc).AddTicks(3196), "Susan Lewis" },
                    { new Guid("e937a4a0-9657-4a1e-9f75-71383f3a46f3"), new Guid("d6a4af77-d8e0-4e2e-a2ce-aac253fba96d"), new DateTime(2023, 12, 23, 15, 18, 5, 163, DateTimeKind.Utc).AddTicks(3188), "Jessica Carter" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_LobbyId",
                table: "Meeting",
                column: "LobbyId");

            migrationBuilder.CreateIndex(
                name: "IX_UserWeight_LobbyId",
                table: "UserWeight",
                column: "LobbyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntertainmentEntity");

            migrationBuilder.DropTable(
                name: "Meeting");

            migrationBuilder.DropTable(
                name: "UserWeight");

            migrationBuilder.DropTable(
                name: "Lobby");
        }
    }
}
