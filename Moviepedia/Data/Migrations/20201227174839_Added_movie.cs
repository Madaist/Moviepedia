using Microsoft.EntityFrameworkCore.Migrations;

namespace Moviepedia.Data.Migrations
{
    public partial class Added_movie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: "2",
                column: "Picture",
                value: "https://i.ibb.co/BVsDhT9/1200px-Kate-Winslet-at-the-2017-Toronto-International-Film-Festival-cropped.jpg");

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Age", "FirstName", "LastName", "Picture" },
                values: new object[,]
                {
                    { "9", 80, "Al", "Pacino", "https://i.ibb.co/SNGpVN2/330px-Al-Pacino.jpg" },
                    { "10", 80, "Marlon", "Brando", "https://i.ibb.co/S0tQS7z/330px-Marlon-Brando-by-Edward-Cronenweth-1955.jpg" }
                });

            migrationBuilder.InsertData(
                table: "MovieInfos",
                columns: new[] { "Id", "BoxOffice", "Category", "ReleaseYear", "StoryLine" },
                values: new object[] { "6", "$246–287 million", "Crime", 1972, "The Godfather 'Don' Vito Corleone is the head of the Corleone mafia family in New York. He is at the event of his daughter's wedding. Michael, Vito's youngest son and a decorated WW II Marine is also present at the wedding. Michael seems to be uninterested in being a part of the family business. Vito is a powerful man, and is kind to all those who give him respect but is ruthless against those who do not. But when a powerful and treacherous rival wants to sell drugs and needs the Don's influence for the same, Vito refuses to do it. What follows is a clash between Vito's fading old values and the new ways which may cause Michael to do the thing he was most reluctant in doing and wage a mob war against all the other mafia families which could tear the Corleone family apart." });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "MovieInfoId", "Picture", "Title" },
                values: new object[] { "6", "6", "https://i.ibb.co/cv7Ht6Y/The-Godfather-The-Game.jpg", "The Godfather" });

            migrationBuilder.InsertData(
                table: "MovieActors",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[] { "10", "9", "6" });

            migrationBuilder.InsertData(
                table: "MovieActors",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[] { "11", "10", "6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "Id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "Id",
                keyValue: "11");

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: "9");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "MovieInfos",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: "2",
                column: "Picture",
                value: "https://i.ibb.co/71CCNdp/Kate-Winslet-arriving-for-the-Titanic-3-D-premiere-at-the-Royal-Albert-Hall-Kensington-London-27-03.jpg");
        }
    }
}
