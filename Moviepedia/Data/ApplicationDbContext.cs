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
            modelBuilder.Entity<Actor>().HasData(new Actor { Id = "2", FirstName = "Kate", LastName = "Winslet", Age = 45, Picture = "https://i.ibb.co/71CCNdp/Kate-Winslet-arriving-for-the-Titanic-3-D-premiere-at-the-Royal-Albert-Hall-Kensington-London-27-03.jpg" });
            modelBuilder.Entity<Actor>().HasData(new Actor { Id = "3", FirstName = "Brad", LastName = "Pitt", Age = 56, Picture = "https://i.ibb.co/Lr6X6mm/1200px-Brad-Pitt-2019-by-Glenn-Francis.jpg" });
            modelBuilder.Entity<Actor>().HasData(new Actor { Id = "4", FirstName = "Morgan", LastName = "Freeman", Age = 83, Picture = "https://i.ibb.co/vhvVJT7/Morgan-Freeman-Deauville-2018.jpg" });
            modelBuilder.Entity<Actor>().HasData(new Actor { Id = "5", FirstName = "Johnny", LastName = "Depp", Age = 57, Picture = "https://i.ibb.co/2swVsWn/db0a8c0a8bce7a25d0744ed190f5058098-johnny-depp-rsquare-w1200.jpg" });

            modelBuilder.Entity<MovieInfo>().HasData(new MovieInfo { Id = "1", StoryLine = "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic.", BoxOffice = "$2.195 billion", Category = "Romance", ReleaseYear = 1997 });
            modelBuilder.Entity<MovieInfo>().HasData(new MovieInfo { Id = "2", StoryLine = "Two detectives, a rookie and a veteran, hunt a serial killer who uses the seven deadly sins as his motives.", BoxOffice = "$327.3 million", Category = " Psychological crime thriller", ReleaseYear = 1995 });
            modelBuilder.Entity<MovieInfo>().HasData(new MovieInfo { Id = "3", StoryLine = "Blacksmith Will Turner teams up with eccentric pirate 'Captain' Jack Sparrow to save his love, the governor's daughter, from Jack's former pirate allies, who are now undead.", BoxOffice = "$654.3 million[", Category = "Fantasy", ReleaseYear = 2003 });

            modelBuilder.Entity<Movie>().HasData(new Movie { Id = "1", Title = "Titanic", MovieInfoId = "1", Picture = "https://i.ibb.co/KwSNZGD/titanic-scufundare-new-york-1170x658.jpg" });
            modelBuilder.Entity<Movie>().HasData(new Movie { Id = "2", Title = "Se7en", MovieInfoId = "2", Picture = "https://i.ibb.co/YPXwbCK/MV5-BOTUw-ODM5-MTct-Zjcz-Mi00-OTk4-LTg3-NWUt-Nm-Vh-MTAz-NTNj-Yjcy-Xk-Ey-Xk-Fqc-Gde-QXVy-Nj-U0-OTQ0-O.jpg" });
            modelBuilder.Entity<Movie>().HasData(new Movie { Id = "3", Title = "Pirates of the Caribbean", MovieInfoId = "3", Picture = "https://i.ibb.co/xSLyF7n/the-pirates-of-the-caribbean-the-curse-of-the-black-pearl-990363l-600x0-w-59f5b761.jpg" });

            modelBuilder.Entity<MovieActors>().HasData(new MovieActors { Id = "1", MovieId = "1", ActorId = "1" });
            modelBuilder.Entity<MovieActors>().HasData(new MovieActors { Id = "2", MovieId = "1", ActorId = "2" });
            modelBuilder.Entity<MovieActors>().HasData(new MovieActors { Id = "3", MovieId = "2", ActorId = "3" });
            modelBuilder.Entity<MovieActors>().HasData(new MovieActors { Id = "4", MovieId = "2", ActorId = "4" });
            modelBuilder.Entity<MovieActors>().HasData(new MovieActors { Id = "5", MovieId = "3", ActorId = "5" });
        }
    }
}

