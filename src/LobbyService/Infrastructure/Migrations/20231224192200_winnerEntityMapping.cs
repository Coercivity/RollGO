using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class winnerEntityMapping : Migration
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
                    KinopoiskId = table.Column<int>(type: "int", nullable: false),
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
                name: "LobbyUser",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    LobbyId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LobbyUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LobbyUser_Lobby_LobbyId",
                        column: x => x.LobbyId,
                        principalTable: "Lobby",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Meeting",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false, defaultValueSql: "uuid_generate_v4()"),
                    LobbyId = table.Column<Guid>(type: "uuid", nullable: false),
                    WinnerId = table.Column<Guid>(type: "uuid", nullable: true),
                    WinnerEntityId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsActive = table.Column<bool>(type: "bool", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meeting", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Meeting_EntertainmentEntity_WinnerEntityId",
                        column: x => x.WinnerEntityId,
                        principalTable: "EntertainmentEntity",
                        principalColumn: "Id");
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
                    { new Guid("472d95cc-381a-4d2f-b5eb-3fb282b10920"), new Guid("d754bb36-659d-4734-81f5-76ab8fe6b69b"), new DateTime(2023, 12, 24, 19, 22, 0, 128, DateTimeKind.Utc).AddTicks(9816), "spark" },
                    { new Guid("b70bd0bc-7309-46c1-a62f-816f668aad5e"), new Guid("3b05d3a6-7445-4f85-a07f-c45a70177647"), new DateTime(2023, 12, 24, 19, 22, 0, 128, DateTimeKind.Utc).AddTicks(9785), "yo_mama" },
                    { new Guid("e06acd16-ab24-44f7-baa3-1b5d07d73b0c"), new Guid("fa4812f1-20e6-4795-be8b-8fe5de551265"), new DateTime(2023, 12, 24, 19, 22, 0, 128, DateTimeKind.Utc).AddTicks(9812), "impostor" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LobbyUser_LobbyId",
                table: "LobbyUser",
                column: "LobbyId");

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_LobbyId",
                table: "Meeting",
                column: "LobbyId");

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_WinnerEntityId",
                table: "Meeting",
                column: "WinnerEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_UserWeight_LobbyId",
                table: "UserWeight",
                column: "LobbyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LobbyUser");

            migrationBuilder.DropTable(
                name: "Meeting");

            migrationBuilder.DropTable(
                name: "UserWeight");

            migrationBuilder.DropTable(
                name: "EntertainmentEntity");

            migrationBuilder.DropTable(
                name: "Lobby");
        }
    }
}
