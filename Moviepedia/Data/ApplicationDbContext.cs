using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Moviepedia.Models;

namespace Moviepedia.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<MovieInfo> MovieInfos { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<MovieActors> MovieActors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Movie>().ToTable("Movies");
            modelBuilder.Entity<Actor>().ToTable("Actors");
            modelBuilder.Entity<Review>().ToTable("Reviews");
            modelBuilder.Entity<MovieActors>().ToTable("MovieActors");
            modelBuilder.Entity<MovieInfo>().ToTable("MovieInfos");
            modelBuilder.Entity<ApplicationUser>().ToTable("AspNetUsers");

            modelBuilder.Entity<Actor>().HasData(new Actor { Id = "1", FirstName = "Leonardo", LastName = "DiCaprio", Age = 46, Picture = "https://i.ibb.co/Yh8RxDm/330px-Leonardo-Di-Caprio-Nov08.jpg" });
            modelBuilder.Entity<Actor>().HasData(new Actor { Id = "2", FirstName = "Kate", LastName = "Winslet", Age = 45, Picture = "https://i.ibb.co/BVsDhT9/1200px-Kate-Winslet-at-the-2017-Toronto-International-Film-Festival-cropped.jpg" });
            modelBuilder.Entity<Actor>().HasData(new Actor { Id = "3", FirstName = "Brad", LastName = "Pitt", Age = 56, Picture = "https://i.ibb.co/Lr6X6mm/1200px-Brad-Pitt-2019-by-Glenn-Francis.jpg" });
            modelBuilder.Entity<Actor>().HasData(new Actor { Id = "4", FirstName = "Morgan", LastName = "Freeman", Age = 83, Picture = "https://i.ibb.co/vhvVJT7/Morgan-Freeman-Deauville-2018.jpg" });
            modelBuilder.Entity<Actor>().HasData(new Actor { Id = "5", FirstName = "Johnny", LastName = "Depp", Age = 57, Picture = "https://i.ibb.co/2swVsWn/db0a8c0a8bce7a25d0744ed190f5058098-johnny-depp-rsquare-w1200.jpg" });
            modelBuilder.Entity<Actor>().HasData(new Actor { Id = "6", FirstName = "Tim", LastName = "Robbins", Age = 62, Picture = "https://i.ibb.co/MfmVJ4q/Tim-Robbins.jpg" });
            modelBuilder.Entity<Actor>().HasData(new Actor { Id = "7", FirstName = "Sam", LastName = "Worthington", Age = 44, Picture = "https://i.ibb.co/Sd9r9Fj/Sam-Worthington-4-2013.jpg" });
            modelBuilder.Entity<Actor>().HasData(new Actor { Id = "8", FirstName = "Zoe", LastName = "Saldana", Age = 42, Picture = "https://i.ibb.co/CzfVnff/Zoe-Saldana.jpg" });
            modelBuilder.Entity<Actor>().HasData(new Actor { Id = "9", FirstName = "Al", LastName = "Pacino", Age = 80, Picture = "https://i.ibb.co/SNGpVN2/330px-Al-Pacino.jpg" });
            modelBuilder.Entity<Actor>().HasData(new Actor { Id = "10", FirstName = "Marlon", LastName = "Brando", Age = 80, Picture = "https://i.ibb.co/S0tQS7z/330px-Marlon-Brando-by-Edward-Cronenweth-1955.jpg" });

            modelBuilder.Entity<MovieInfo>().HasData(new MovieInfo
            {
                Id = "1",
                StoryLine = "After winning a trip on the RMS Titanic during a dockside card game, American Jack Dawson spots the society girl Rose DeWitt Bukater who is on her way to Philadelphia to marry her rich snob fiancé Caledon Hockley. Rose feels helplessly trapped by her situation and makes her way to the aft deck and thinks of suicide until she is rescued by Jack. Cal is therefore obliged to invite Jack to dine at their first-class table where he suffers through the slights of his snobbish hosts. In return, he spirits Rose off to third-class for an evening of dancing, giving her the time of her life. Deciding to forsake her intended future all together, Rose asks Jack, who has made his living making sketches on the streets of Paris, to draw her in the nude wearing the invaluable blue diamond Cal has given her. Cal finds out and has Jack locked away. Soon afterwards, the ship hits an iceberg and Rose must find Jack while both must run from Cal even as the ship sinks deeper into the freezing water.",
                BoxOffice = "$2.195 billion",
                Category = "Romance",
                ReleaseYear = 1997
            });
            modelBuilder.Entity<MovieInfo>().HasData(new MovieInfo
            {
                Id = "2",
                StoryLine = "A film about two homicide detectives' (Morgan Freeman and Brad Pitt) desperate hunt for a serial killer who justifies his crimes as absolution for the world's ignorance of the Seven Deadly Sins. The movie takes us from the tortured remains of one victim to the next as the sociopathic 'John Doe' (Kevin Spacey) sermonizes to Detectives Somerset and Mills -- one sin at a time. The sin of Gluttony comes first and the murderer's terrible capacity is graphically demonstrated in the dark and subdued tones characteristic of film noir. The seasoned and cultured but jaded Somerset researches the Seven Deadly Sins in an effort to understand the killer's modus operandi while the bright but green and impulsive Detective Mills (Pitt) scoffs at his efforts to get inside the mind of a killer...",
                BoxOffice = "$327.3 million",
                Category = " Psychological crime thriller",
                ReleaseYear = 1995
            });
            modelBuilder.Entity<MovieInfo>().HasData(new MovieInfo
            {
                Id = "3",
                StoryLine = "William Turner, a resourceful young blacksmith, teams up with the eccentric pirate 'Captain' Jack Sparrow to save his love, the Governor's daughter, Elizabeth Swann, who has been mistakenly captured by the clever and treacherous Barbossa, a former ally of Jack, to make a blood sacrifice so as to end the curse that has been casted upon him and his crew. Will and Jack steal a ship from the Royal Navy and arrive at Tortuga, a pirate port. There Jack meets his friend Joshamee Gibbs and with a buccaneer and 'able bodied' crew, set sail to save Elizabeth and take back the Black Pearl. Meanwhile, Barbossa discovers that not Elizabeth's but someone else's blood was required for the sacrifice. Whose blood is it?",
                BoxOffice = "$654.3 million",
                Category = "Fantasy",
                ReleaseYear = 2003
            });
            modelBuilder.Entity<MovieInfo>().HasData(new MovieInfo
            {
                Id = "4",
                StoryLine = "Bank Merchant Andy Dufresne is convicted of the murder of his wife and her lover, and sentenced to life imprisonment at Shawshank prison. Life seems to have taken a turn for the worse, but fortunately Andy befriends some of the other inmates, in particular a character known only as Red. Over time Andy finds ways to live out life with relative ease as one can in a prison, leaving a message for all that while the body may be locked away in a cell, the spirit can never be truly imprisoned.",
                BoxOffice = "$58.3 million",
                Category = "Drama",
                ReleaseYear = 1994

            });
            modelBuilder.Entity<MovieInfo>().HasData(new MovieInfo
            {
                Id = "5",
                StoryLine = "When his brother is killed in a robbery, paraplegic Marine Jake Sully decides to take his place in a mission on the distant world of Pandora. There he learns of greedy corporate figurehead Parker Selfridge's intentions of driving off the native humanoid 'Na'vi' in order to mine for the precious material scattered throughout their rich woodland. In exchange for the spinal surgery that will fix his legs, Jake gathers knowledge, of the Indigenous Race and their Culture, for the cooperating military unit spearheaded by gung-ho Colonel Quaritch, while simultaneously attempting to infiltrate the Na'vi people with the use of an 'avatar' identity. While Jake begins to bond with the native tribe and quickly falls in love with the beautiful alien Neytiri, the restless Colonel moves forward with his ruthless extermination tactics, forcing the soldier to take a stand - and fight back in an epic battle for the fate of Pandora.",
                BoxOffice = "$2.79 billion",
                Category = "Epic Science Fiction",
                ReleaseYear = 2009
            });
            modelBuilder.Entity<MovieInfo>().HasData(new MovieInfo
            {
                Id = "6",
                StoryLine = "The Godfather 'Don' Vito Corleone is the head of the Corleone mafia family in New York. He is at the event of his daughter's wedding. Michael, Vito's youngest son and a decorated WW II Marine is also present at the wedding. Michael seems to be uninterested in being a part of the family business. Vito is a powerful man, and is kind to all those who give him respect but is ruthless against those who do not. But when a powerful and treacherous rival wants to sell drugs and needs the Don's influence for the same, Vito refuses to do it. What follows is a clash between Vito's fading old values and the new ways which may cause Michael to do the thing he was most reluctant in doing and wage a mob war against all the other mafia families which could tear the Corleone family apart.",
                BoxOffice = "$246–287 million",
                Category = "Crime",
                ReleaseYear = 1972
            });

            modelBuilder.Entity<Movie>().HasData(new Movie { Id = "1", Title = "Titanic", MovieInfoId = "1", Picture = "https://i.ibb.co/Czs5FwB/titanic.jpg" });
            modelBuilder.Entity<Movie>().HasData(new Movie { Id = "2", Title = "Se7en", MovieInfoId = "2", Picture = "https://i.ibb.co/YPXwbCK/MV5-BOTUw-ODM5-MTct-Zjcz-Mi00-OTk4-LTg3-NWUt-Nm-Vh-MTAz-NTNj-Yjcy-Xk-Ey-Xk-Fqc-Gde-QXVy-Nj-U0-OTQ0-O.jpg" });
            modelBuilder.Entity<Movie>().HasData(new Movie { Id = "3", Title = "Pirates of the Caribbean", MovieInfoId = "3", Picture = "https://i.ibb.co/xSLyF7n/the-pirates-of-the-caribbean-the-curse-of-the-black-pearl-990363l-600x0-w-59f5b761.jpg" });
            modelBuilder.Entity<Movie>().HasData(new Movie { Id = "4", Title = "The Shawshank Redemption", MovieInfoId = "4", Picture = "https://i.ibb.co/0qRXm22/shawshank.jpg" });
            modelBuilder.Entity<Movie>().HasData(new Movie { Id = "5", Title = "Avatar", MovieInfoId = "5", Picture = "https://i.ibb.co/LkXWRyr/avatar.jpg" });
            modelBuilder.Entity<Movie>().HasData(new Movie { Id = "6", Title = "The Godfather", MovieInfoId = "6", Picture = "https://i.ibb.co/cv7Ht6Y/The-Godfather-The-Game.jpg" });

            modelBuilder.Entity<MovieActors>().HasData(new MovieActors { Id = "1", MovieId = "1", ActorId = "1" });
            modelBuilder.Entity<MovieActors>().HasData(new MovieActors { Id = "2", MovieId = "1", ActorId = "2" });
            modelBuilder.Entity<MovieActors>().HasData(new MovieActors { Id = "3", MovieId = "2", ActorId = "3" });
            modelBuilder.Entity<MovieActors>().HasData(new MovieActors { Id = "4", MovieId = "2", ActorId = "4" });
            modelBuilder.Entity<MovieActors>().HasData(new MovieActors { Id = "5", MovieId = "3", ActorId = "5" });
            modelBuilder.Entity<MovieActors>().HasData(new MovieActors { Id = "6", MovieId = "4", ActorId = "4" });
            modelBuilder.Entity<MovieActors>().HasData(new MovieActors { Id = "7", MovieId = "4", ActorId = "6" });
            modelBuilder.Entity<MovieActors>().HasData(new MovieActors { Id = "8", MovieId = "5", ActorId = "7" });
            modelBuilder.Entity<MovieActors>().HasData(new MovieActors { Id = "9", MovieId = "5", ActorId = "8" });
            modelBuilder.Entity<MovieActors>().HasData(new MovieActors { Id = "10", MovieId = "6", ActorId = "9" });
            modelBuilder.Entity<MovieActors>().HasData(new MovieActors { Id = "11", MovieId = "6", ActorId = "10" });
        }
    }
}

