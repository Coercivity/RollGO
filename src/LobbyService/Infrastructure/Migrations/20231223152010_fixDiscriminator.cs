using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fixDiscriminator : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("36ce8946-ba8b-4ad1-b161-207415a1fb3d"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("38b63150-e04b-4c02-95f8-169e70d03122"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("4200daf6-8a52-4f6b-ba84-2cd0ad9590c8"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("47987ac3-3e18-400a-9ee4-78f8e07b589f"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("761b5cb6-ec36-4058-a992-68467b2ae179"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("8370c42c-6f34-485b-a717-6f830a85d080"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("93662aea-f22d-487c-94fc-db55c37e9415"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("9ea5051e-1e71-4e24-8f57-c985a57a6ac2"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("bbbcc325-1c9e-419c-975f-c3aaefdf09e9"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("e937a4a0-9657-4a1e-9f75-71383f3a46f3"));

            migrationBuilder.DropColumn(
                name: "IS_SERIES",
                table: "EntertainmentEntity");

            migrationBuilder.InsertData(
                table: "Lobby",
                columns: new[] { "Id", "AdminId", "CreatedDateTime", "Name" },
                values: new object[,]
                {
                    { new Guid("0b350621-1846-41e8-a754-eca73f225be0"), new Guid("f19d255c-8a7d-4081-b2a0-f489ac6266dc"), new DateTime(2023, 12, 23, 15, 20, 10, 12, DateTimeKind.Utc).AddTicks(6368), "Shirley Green" },
                    { new Guid("1391e6e5-0408-4e9b-896a-7f46b8846067"), new Guid("07d2313a-0b27-412c-852b-ceb894bd7c1e"), new DateTime(2023, 12, 23, 15, 20, 10, 12, DateTimeKind.Utc).AddTicks(6372), "Samuel Gonzalez" },
                    { new Guid("34e65be4-1a44-4d50-9803-f364d2cc9ac1"), new Guid("d2620132-a31f-4b35-b5c3-2fc4ce59493c"), new DateTime(2023, 12, 23, 15, 20, 10, 12, DateTimeKind.Utc).AddTicks(6351), "Elizabeth Robinson" },
                    { new Guid("3df7a4b9-cfe9-418a-9a08-4c5503533f91"), new Guid("b4a3fe96-a4c2-4629-a59e-c5dd2664186d"), new DateTime(2023, 12, 23, 15, 20, 10, 12, DateTimeKind.Utc).AddTicks(6357), "Andre Hill" },
                    { new Guid("43af2362-7855-4ae9-bba1-e6394e01a469"), new Guid("79d52242-5076-45e3-aa17-79ff41281ec7"), new DateTime(2023, 12, 23, 15, 20, 10, 12, DateTimeKind.Utc).AddTicks(6339), "Barbara Nelson" },
                    { new Guid("716c383b-7373-405a-9744-ed933799f862"), new Guid("160eed34-7233-402b-a961-f8579e99d2b2"), new DateTime(2023, 12, 23, 15, 20, 10, 12, DateTimeKind.Utc).AddTicks(6354), "David Hernandez" },
                    { new Guid("82231ec2-b463-4783-8027-2ea6c2c971de"), new Guid("fbfe2cbd-e18c-4af3-b5bc-9b18db6b1616"), new DateTime(2023, 12, 23, 15, 20, 10, 12, DateTimeKind.Utc).AddTicks(6374), "Liam Flores" },
                    { new Guid("8467ff00-38dd-4515-b0bf-0d288fc0ca75"), new Guid("34ed9b8f-4cef-41d5-8ea2-d9e5ff3617f2"), new DateTime(2023, 12, 23, 15, 20, 10, 12, DateTimeKind.Utc).AddTicks(6365), "Betty Jackson" },
                    { new Guid("a17df574-89f7-4f8c-99b8-c72586de30ec"), new Guid("be459c5c-0c38-4adc-be85-12c3d0c607d4"), new DateTime(2023, 12, 23, 15, 20, 10, 12, DateTimeKind.Utc).AddTicks(6379), "Julian Rodriguez" },
                    { new Guid("c794ad7a-a5d6-4f81-9d66-2bd399a3d720"), new Guid("fd096a11-cbdc-4807-a07a-285f905f4572"), new DateTime(2023, 12, 23, 15, 20, 10, 12, DateTimeKind.Utc).AddTicks(6361), "Matthew Hall" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("0b350621-1846-41e8-a754-eca73f225be0"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("1391e6e5-0408-4e9b-896a-7f46b8846067"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("34e65be4-1a44-4d50-9803-f364d2cc9ac1"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("3df7a4b9-cfe9-418a-9a08-4c5503533f91"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("43af2362-7855-4ae9-bba1-e6394e01a469"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("716c383b-7373-405a-9744-ed933799f862"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("82231ec2-b463-4783-8027-2ea6c2c971de"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("8467ff00-38dd-4515-b0bf-0d288fc0ca75"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("a17df574-89f7-4f8c-99b8-c72586de30ec"));

            migrationBuilder.DeleteData(
                table: "Lobby",
                keyColumn: "Id",
                keyValue: new Guid("c794ad7a-a5d6-4f81-9d66-2bd399a3d720"));

            migrationBuilder.AddColumn<bool>(
                name: "IS_SERIES",
                table: "EntertainmentEntity",
                type: "boolean",
                nullable: false,
                defaultValue: false);

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
        }
    }
}
