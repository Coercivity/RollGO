using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemoveAccessToken : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessToken",
                table: "UserSession");

            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "UserSession");

            migrationBuilder.AddColumn<Guid>(
                name: "RefreshTokenId",
                table: "UserSession",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RefreshTokenId",
                table: "UserSession");

            migrationBuilder.AddColumn<string>(
                name: "AccessToken",
                table: "UserSession",
                type: "varchar",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "UserSession",
                type: "varchar",
                nullable: false,
                defaultValue: "");
        }
    }
}
