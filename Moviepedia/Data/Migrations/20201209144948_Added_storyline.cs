using Microsoft.EntityFrameworkCore.Migrations;

namespace Moviepedia.Data.Migrations
{
    public partial class Added_storyline : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StoryLine",
                table: "MovieInfos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StoryLine",
                table: "MovieInfos");
        }
    }
}
