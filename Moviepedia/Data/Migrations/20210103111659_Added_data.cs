using Microsoft.EntityFrameworkCore.Migrations;

namespace Moviepedia.Data.Migrations
{
    public partial class Added_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: "5",
                column: "Picture",
                value: "https://i.ibb.co/svgT0xb/330px-Johnny-Depp-2757-cropped.jpg");

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Age", "FirstName", "LastName", "Picture" },
                values: new object[] { "12", 68, "Frances", "Fisher", "https://i.ibb.co/grXmDnw/Mandatory-Credit-Photo-by-Stewart-Cook-REX-Shutterstock-9638076aa-Frances-Fisher-Race-to-Erase-MS-Ga.jpg" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Age", "FirstName", "LastName", "Picture" },
                values: new object[] { "11", 43, "Orlando", "Bloom", "https://i.ibb.co/6DLDrjZ/330px-Orlando-Bloom-at-Venice-Festival.jpg" });

            migrationBuilder.InsertData(
                table: "MovieActors",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[] { "12", "11", "3" });

            migrationBuilder.InsertData(
                table: "MovieActors",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[] { "13", "12", "1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "Id",
                keyValue: "12");

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "Id",
                keyValue: "13");

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: "11");

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: "12");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: "5",
                column: "Picture",
                value: "https://i.ibb.co/2swVsWn/db0a8c0a8bce7a25d0744ed190f5058098-johnny-depp-rsquare-w1200.jpg");
        }
    }
}
