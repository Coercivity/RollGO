using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddConstraints : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "User",
                table: "UserSession");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "UserSession",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_UserSession_UserId",
                table: "UserSession",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserSession_User_UserId",
                table: "UserSession",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserSession_User_UserId",
                table: "UserSession");

            migrationBuilder.DropIndex(
                name: "IX_UserSession_UserId",
                table: "UserSession");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserSession");

            migrationBuilder.AddColumn<string>(
                name: "User",
                table: "UserSession",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
