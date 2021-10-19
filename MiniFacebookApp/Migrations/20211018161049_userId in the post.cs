using Microsoft.EntityFrameworkCore.Migrations;

namespace MiniFacebookApp.Migrations
{
    public partial class userIdinthepost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Posts");
        }
    }
}
