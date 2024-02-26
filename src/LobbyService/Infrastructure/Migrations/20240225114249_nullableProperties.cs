using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class nullableProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "Year",
                table: "EntertainmentEntities",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "RatingKinopoisk",
                table: "EntertainmentEntities",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<double>(
                name: "RatingImdb",
                table: "EntertainmentEntities",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<int>(
                name: "FilmLength",
                table: "EntertainmentEntities",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.InsertData(
                table: "Lobby",
                columns: new[] { "Id", "AdminId", "CreatedDateTime", "MinimalRating", "MoviesPerUser", "Name", "WithCoefficient" },
                values: new object[,]
                {
                    { new Guid("47fdeb74-078e-49d4-a35a-020aad3d0514"), new Guid("ced8a9d5-5312-4f03-8823-17e7cc91af52"), new DateTime(2024, 2, 25, 11, 42, 48, 908, DateTimeKind.Utc).AddTicks(4268), 7.5, 2, "krab", true },
                    { new Guid("73dc409e-9385-4f3d-a6f2-7a9a7628d707"), new Guid("6574235b-7cfb-45ca-a8ef-ced7baf6f2d6"), new DateTime(2024, 2, 25, 11, 42, 48, 908, DateTimeKind.Utc).AddTicks(4257), 7.5, 2, "guagg", true },
                    { new Guid("c7ac4319-bc01-4b52-99ec-8f573a905c77"), new Guid("b5c17515-c708-4392-a5c7-6137e9cb2964"), new DateTime(2024, 2, 25, 11, 42, 48, 908, DateTimeKind.Utc).AddTicks(4231), 7.5, 2, "t@t@puchi", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("47fdeb74-078e-49d4-a35a-020aad3d0514"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("73dc409e-9385-4f3d-a6f2-7a9a7628d707"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("c7ac4319-bc01-4b52-99ec-8f573a905c77"));

            migrationBuilder.AlterColumn<int>(
                name: "Year",
                table: "EntertainmentEntities",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "RatingKinopoisk",
                table: "EntertainmentEntities",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "RatingImdb",
                table: "EntertainmentEntities",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FilmLength",
                table: "EntertainmentEntities",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

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
    }
}
