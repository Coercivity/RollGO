using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemoveLinkEntitiesLinkFromMeeting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Lobby",
                columns: new[] { "Id", "AdminId", "CreatedDateTime", "MinimalRating", "MoviesPerUser", "Name", "WithCoefficient" },
                values: new object[,]
                {
                    { new Guid("279b7964-45e5-43e0-980e-d701a15a5b6d"), new Guid("2f3f7675-b6c4-4807-ba85-4300139422d6"), new DateTime(2024, 1, 27, 18, 12, 24, 477, DateTimeKind.Utc).AddTicks(362), 7.5, 2, "am0gus", true },
                    { new Guid("9acc127c-619c-4dfb-bd8b-1c1b30d2138f"), new Guid("ff7195ef-2765-433e-aa6d-68aa8a32e0d7"), new DateTime(2024, 1, 27, 18, 12, 24, 477, DateTimeKind.Utc).AddTicks(335), 7.5, 2, "guagg", true },
                    { new Guid("e05d9aba-23fa-471d-9ffc-8bdcd7cf9149"), new Guid("00d42a9a-197e-489e-a5de-34def86dde06"), new DateTime(2024, 1, 27, 18, 12, 24, 477, DateTimeKind.Utc).AddTicks(298), 7.5, 2, "el_juan", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("279b7964-45e5-43e0-980e-d701a15a5b6d"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("9acc127c-619c-4dfb-bd8b-1c1b30d2138f"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("e05d9aba-23fa-471d-9ffc-8bdcd7cf9149"));

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
    }
}
