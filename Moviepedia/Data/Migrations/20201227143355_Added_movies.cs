using Microsoft.EntityFrameworkCore.Migrations;

namespace Moviepedia.Data.Migrations
{
    public partial class Added_movies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Age", "FirstName", "LastName", "Picture" },
                values: new object[,]
                {
                    { "6", 62, "Tim", "Robbins", "https://i.ibb.co/MfmVJ4q/Tim-Robbins.jpg" },
                    { "7", 44, "Sam", "Worthington", "https://i.ibb.co/Sd9r9Fj/Sam-Worthington-4-2013.jpg" },
                    { "8", 42, "Zoe", "Saldana", "https://i.ibb.co/CzfVnff/Zoe-Saldana.jpg" }
                });

            migrationBuilder.UpdateData(
                table: "MovieInfos",
                keyColumn: "Id",
                keyValue: "1",
                column: "StoryLine",
                value: "After winning a trip on the RMS Titanic during a dockside card game, American Jack Dawson spots the society girl Rose DeWitt Bukater who is on her way to Philadelphia to marry her rich snob fiancé Caledon Hockley. Rose feels helplessly trapped by her situation and makes her way to the aft deck and thinks of suicide until she is rescued by Jack. Cal is therefore obliged to invite Jack to dine at their first-class table where he suffers through the slights of his snobbish hosts. In return, he spirits Rose off to third-class for an evening of dancing, giving her the time of her life. Deciding to forsake her intended future all together, Rose asks Jack, who has made his living making sketches on the streets of Paris, to draw her in the nude wearing the invaluable blue diamond Cal has given her. Cal finds out and has Jack locked away. Soon afterwards, the ship hits an iceberg and Rose must find Jack while both must run from Cal even as the ship sinks deeper into the freezing water.");

            migrationBuilder.UpdateData(
                table: "MovieInfos",
                keyColumn: "Id",
                keyValue: "2",
                column: "StoryLine",
                value: "A film about two homicide detectives' (Morgan Freeman and Brad Pitt) desperate hunt for a serial killer who justifies his crimes as absolution for the world's ignorance of the Seven Deadly Sins. The movie takes us from the tortured remains of one victim to the next as the sociopathic 'John Doe' (Kevin Spacey) sermonizes to Detectives Somerset and Mills -- one sin at a time. The sin of Gluttony comes first and the murderer's terrible capacity is graphically demonstrated in the dark and subdued tones characteristic of film noir. The seasoned and cultured but jaded Somerset researches the Seven Deadly Sins in an effort to understand the killer's modus operandi while the bright but green and impulsive Detective Mills (Pitt) scoffs at his efforts to get inside the mind of a killer...");

            migrationBuilder.UpdateData(
                table: "MovieInfos",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "BoxOffice", "StoryLine" },
                values: new object[] { "$654.3 million", "William Turner, a resourceful young blacksmith, teams up with the eccentric pirate 'Captain' Jack Sparrow to save his love, the Governor's daughter, Elizabeth Swann, who has been mistakenly captured by the clever and treacherous Barbossa, a former ally of Jack, to make a blood sacrifice so as to end the curse that has been casted upon him and his crew. Will and Jack steal a ship from the Royal Navy and arrive at Tortuga, a pirate port. There Jack meets his friend Joshamee Gibbs and with a buccaneer and 'able bodied' crew, set sail to save Elizabeth and take back the Black Pearl. Meanwhile, Barbossa discovers that not Elizabeth's but someone else's blood was required for the sacrifice. Whose blood is it?" });

            migrationBuilder.InsertData(
                table: "MovieInfos",
                columns: new[] { "Id", "BoxOffice", "Category", "ReleaseYear", "StoryLine" },
                values: new object[,]
                {
                    { "4", "$58.3 million", "Drama", 1994, "Bank Merchant Andy Dufresne is convicted of the murder of his wife and her lover, and sentenced to life imprisonment at Shawshank prison. Life seems to have taken a turn for the worse, but fortunately Andy befriends some of the other inmates, in particular a character known only as Red. Over time Andy finds ways to live out life with relative ease as one can in a prison, leaving a message for all that while the body may be locked away in a cell, the spirit can never be truly imprisoned." },
                    { "5", "$2.79 billion", "Epic Science Fiction", 2009, "When his brother is killed in a robbery, paraplegic Marine Jake Sully decides to take his place in a mission on the distant world of Pandora. There he learns of greedy corporate figurehead Parker Selfridge's intentions of driving off the native humanoid 'Na'vi' in order to mine for the precious material scattered throughout their rich woodland. In exchange for the spinal surgery that will fix his legs, Jake gathers knowledge, of the Indigenous Race and their Culture, for the cooperating military unit spearheaded by gung-ho Colonel Quaritch, while simultaneously attempting to infiltrate the Na'vi people with the use of an 'avatar' identity. While Jake begins to bond with the native tribe and quickly falls in love with the beautiful alien Neytiri, the restless Colonel moves forward with his ruthless extermination tactics, forcing the soldier to take a stand - and fight back in an epic battle for the fate of Pandora." }
                });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "1",
                column: "Picture",
                value: "https://i.ibb.co/Czs5FwB/titanic.jpg");

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "MovieInfoId", "Picture", "Title" },
                values: new object[] { "4", "4", "https://i.ibb.co/0qRXm22/shawshank.jpg", "The Shawshank Redemption" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "MovieInfoId", "Picture", "Title" },
                values: new object[] { "5", "5", "https://i.ibb.co/LkXWRyr/avatar.jpg", "Avatar" });

            migrationBuilder.InsertData(
                table: "MovieActors",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[,]
                {
                    { "6", "4", "4" },
                    { "7", "6", "4" },
                    { "8", "7", "5" },
                    { "9", "8", "5" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "Id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "Id",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "MovieActors",
                keyColumn: "Id",
                keyValue: "9");

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "MovieInfos",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "MovieInfos",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.UpdateData(
                table: "MovieInfos",
                keyColumn: "Id",
                keyValue: "1",
                column: "StoryLine",
                value: "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic.");

            migrationBuilder.UpdateData(
                table: "MovieInfos",
                keyColumn: "Id",
                keyValue: "2",
                column: "StoryLine",
                value: "Two detectives, a rookie and a veteran, hunt a serial killer who uses the seven deadly sins as his motives.");

            migrationBuilder.UpdateData(
                table: "MovieInfos",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "BoxOffice", "StoryLine" },
                values: new object[] { "$654.3 million[", "Blacksmith Will Turner teams up with eccentric pirate 'Captain' Jack Sparrow to save his love, the governor's daughter, from Jack's former pirate allies, who are now undead." });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "1",
                column: "Picture",
                value: "https://i.ibb.co/KwSNZGD/titanic-scufundare-new-york-1170x658.jpg");
        }
    }
}
