using Microsoft.EntityFrameworkCore.Migrations;

namespace Moviepedia.Data.Migrations
{
    public partial class Added_seeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Age", "FirstName", "LastName", "Picture" },
                values: new object[,]
                {
                    { "1", 46, "Leonardo", "DiCaprio", "https://i.ibb.co/Yh8RxDm/330px-Leonardo-Di-Caprio-Nov08.jpg" },
                    { "2", 45, "Kate", "Winslet", "https://i.ibb.co/71CCNdp/Kate-Winslet-arriving-for-the-Titanic-3-D-premiere-at-the-Royal-Albert-Hall-Kensington-London-27-03.jpg" },
                    { "3", 56, "Brad", "Pitt", "https://i.ibb.co/Lr6X6mm/1200px-Brad-Pitt-2019-by-Glenn-Francis.jpg" },
                    { "4", 83, "Morgan", "Freeman", "https://i.ibb.co/vhvVJT7/Morgan-Freeman-Deauville-2018.jpg" },
                    { "5", 57, "Johnny", "Depp", "https://i.ibb.co/2swVsWn/db0a8c0a8bce7a25d0744ed190f5058098-johnny-depp-rsquare-w1200.jpg" }
                });

            migrationBuilder.InsertData(
                table: "MovieInfos",
                columns: new[] { "Id", "BoxOffice", "Category", "ReleaseYear", "StoryLine" },
                values: new object[,]
                {
                    { "1", "$2.195 billion", "Romance", 1997, "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic." },
                    { "2", "$327.3 million", " Psychological crime thriller", 1995, "Two detectives, a rookie and a veteran, hunt a serial killer who uses the seven deadly sins as his motives." },
                    { "3", "$654.3 million[", "Fantasy", 2003, "Blacksmith Will Turner teams up with eccentric pirate 'Captain' Jack Sparrow to save his love, the governor's daughter, from Jack's former pirate allies, who are now undead." }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "MovieInfoId", "Picture", "Title" },
                values: new object[] { "1", "1", "https://i.ibb.co/KwSNZGD/titanic-scufundare-new-york-1170x658.jpg", "Titanic" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "MovieInfoId", "Picture", "Title" },
                values: new object[] { "2", "2", "https://i.ibb.co/YPXwbCK/MV5-BOTUw-ODM5-MTct-Zjcz-Mi00-OTk4-LTg3-NWUt-Nm-Vh-MTAz-NTNj-Yjcy-Xk-Ey-Xk-Fqc-Gde-QXVy-Nj-U0-OTQ0-O.jpg", "Se7en" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "MovieInfoId", "Picture", "Title" },
                values: new object[] { "3", "3", "https://i.ibb.co/xSLyF7n/the-pirates-of-the-caribbean-the-curse-of-the-black-pearl-990363l-600x0-w-59f5b761.jpg", "Pirates of the Caribbean" });

            migrationBuilder.InsertData(
                table: "MovieActors",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[,]
                {
                    { "1", "1", "1" },
                    { "2", "2", "1" },
                    { "3", "3", "2" },
                    { "4", "4", "2" },
                    { "5", "5", "3" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "MovieInfos",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "MovieInfos",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "MovieInfos",
                keyColumn: "Id",
                keyValue: "3");
        }
    }
}
