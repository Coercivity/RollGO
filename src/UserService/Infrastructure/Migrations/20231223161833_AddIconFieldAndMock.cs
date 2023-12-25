using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddIconFieldAndMock : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "User",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedDateTime", "Email", "Icon", "Password", "Username" },
                values: new object[,]
                {
                    { new Guid("7d9a0298-c78b-4695-ba85-328da77dbe49"), new DateTime(2023, 12, 23, 16, 18, 33, 102, DateTimeKind.Utc).AddTicks(4458), "slavoyar@hotmail.com", null, "$2a$11$xjNnZHNqvIKURLF3ldakbeYlhxbXEABXQzQnKDExYmfiELqFM3uzC", "slavoyar" },
                    { new Guid("8f56b3cb-cd9c-4fe0-8634-41c243b077e1"), new DateTime(2023, 12, 23, 16, 18, 33, 102, DateTimeKind.Utc).AddTicks(4497), "serpens@rollgo.com", null, "$2a$11$xjNnZHNqvIKURLF3ldakbeYlhxbXEABXQzQnKDExYmfiELqFM3uzC", "outflow" },
                    { new Guid("e643a90e-1e36-42e9-835c-f67224ac9266"), new DateTime(2023, 12, 23, 16, 18, 33, 102, DateTimeKind.Utc).AddTicks(4499), "serpens@hotmail.com", null, "$2a$11$xjNnZHNqvIKURLF3ldakbeYlhxbXEABXQzQnKDExYmfiELqFM3uzC", "serpens" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("7d9a0298-c78b-4695-ba85-328da77dbe49"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8f56b3cb-cd9c-4fe0-8634-41c243b077e1"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e643a90e-1e36-42e9-835c-f67224ac9266"));

            migrationBuilder.DropColumn(
                name: "Icon",
                table: "User");
        }
    }
}
