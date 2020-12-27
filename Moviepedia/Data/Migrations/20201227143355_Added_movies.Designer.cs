﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Moviepedia.Data;

namespace Moviepedia.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201227143355_Added_movies")]
    partial class Added_movies
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IdentityServer4.EntityFramework.Entities.DeviceFlowCodes", b =>
                {
                    b.Property<string>("UserCode")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(50000);

                    b.Property<string>("DeviceCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime?>("Expiration")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("SubjectId")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("UserCode");

                    b.HasIndex("DeviceCode")
                        .IsUnique();

                    b.HasIndex("Expiration");

                    b.ToTable("DeviceCodes");
                });

            modelBuilder.Entity("IdentityServer4.EntityFramework.Entities.PersistedGrant", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(50000);

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("datetime2");

                    b.Property<string>("SubjectId")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Key");

                    b.HasIndex("Expiration");

                    b.HasIndex("SubjectId", "ClientId", "Type");

                    b.ToTable("PersistedGrants");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Moviepedia.Models.Actor", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Age = 46,
                            FirstName = "Leonardo",
                            LastName = "DiCaprio",
                            Picture = "https://i.ibb.co/Yh8RxDm/330px-Leonardo-Di-Caprio-Nov08.jpg"
                        },
                        new
                        {
                            Id = "2",
                            Age = 45,
                            FirstName = "Kate",
                            LastName = "Winslet",
                            Picture = "https://i.ibb.co/71CCNdp/Kate-Winslet-arriving-for-the-Titanic-3-D-premiere-at-the-Royal-Albert-Hall-Kensington-London-27-03.jpg"
                        },
                        new
                        {
                            Id = "3",
                            Age = 56,
                            FirstName = "Brad",
                            LastName = "Pitt",
                            Picture = "https://i.ibb.co/Lr6X6mm/1200px-Brad-Pitt-2019-by-Glenn-Francis.jpg"
                        },
                        new
                        {
                            Id = "4",
                            Age = 83,
                            FirstName = "Morgan",
                            LastName = "Freeman",
                            Picture = "https://i.ibb.co/vhvVJT7/Morgan-Freeman-Deauville-2018.jpg"
                        },
                        new
                        {
                            Id = "5",
                            Age = 57,
                            FirstName = "Johnny",
                            LastName = "Depp",
                            Picture = "https://i.ibb.co/2swVsWn/db0a8c0a8bce7a25d0744ed190f5058098-johnny-depp-rsquare-w1200.jpg"
                        },
                        new
                        {
                            Id = "6",
                            Age = 62,
                            FirstName = "Tim",
                            LastName = "Robbins",
                            Picture = "https://i.ibb.co/MfmVJ4q/Tim-Robbins.jpg"
                        },
                        new
                        {
                            Id = "7",
                            Age = 44,
                            FirstName = "Sam",
                            LastName = "Worthington",
                            Picture = "https://i.ibb.co/Sd9r9Fj/Sam-Worthington-4-2013.jpg"
                        },
                        new
                        {
                            Id = "8",
                            Age = 42,
                            FirstName = "Zoe",
                            LastName = "Saldana",
                            Picture = "https://i.ibb.co/CzfVnff/Zoe-Saldana.jpg"
                        });
                });

            modelBuilder.Entity("Moviepedia.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Moviepedia.Models.Movie", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MovieInfoId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MovieInfoId")
                        .IsUnique()
                        .HasFilter("[MovieInfoId] IS NOT NULL");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            MovieInfoId = "1",
                            Picture = "https://i.ibb.co/Czs5FwB/titanic.jpg",
                            Title = "Titanic"
                        },
                        new
                        {
                            Id = "2",
                            MovieInfoId = "2",
                            Picture = "https://i.ibb.co/YPXwbCK/MV5-BOTUw-ODM5-MTct-Zjcz-Mi00-OTk4-LTg3-NWUt-Nm-Vh-MTAz-NTNj-Yjcy-Xk-Ey-Xk-Fqc-Gde-QXVy-Nj-U0-OTQ0-O.jpg",
                            Title = "Se7en"
                        },
                        new
                        {
                            Id = "3",
                            MovieInfoId = "3",
                            Picture = "https://i.ibb.co/xSLyF7n/the-pirates-of-the-caribbean-the-curse-of-the-black-pearl-990363l-600x0-w-59f5b761.jpg",
                            Title = "Pirates of the Caribbean"
                        },
                        new
                        {
                            Id = "4",
                            MovieInfoId = "4",
                            Picture = "https://i.ibb.co/0qRXm22/shawshank.jpg",
                            Title = "The Shawshank Redemption"
                        },
                        new
                        {
                            Id = "5",
                            MovieInfoId = "5",
                            Picture = "https://i.ibb.co/LkXWRyr/avatar.jpg",
                            Title = "Avatar"
                        });
                });

            modelBuilder.Entity("Moviepedia.Models.MovieActors", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ActorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MovieId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ActorId");

                    b.HasIndex("MovieId");

                    b.ToTable("MovieActors");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            ActorId = "1",
                            MovieId = "1"
                        },
                        new
                        {
                            Id = "2",
                            ActorId = "2",
                            MovieId = "1"
                        },
                        new
                        {
                            Id = "3",
                            ActorId = "3",
                            MovieId = "2"
                        },
                        new
                        {
                            Id = "4",
                            ActorId = "4",
                            MovieId = "2"
                        },
                        new
                        {
                            Id = "5",
                            ActorId = "5",
                            MovieId = "3"
                        },
                        new
                        {
                            Id = "6",
                            ActorId = "4",
                            MovieId = "4"
                        },
                        new
                        {
                            Id = "7",
                            ActorId = "6",
                            MovieId = "4"
                        },
                        new
                        {
                            Id = "8",
                            ActorId = "7",
                            MovieId = "5"
                        },
                        new
                        {
                            Id = "9",
                            ActorId = "8",
                            MovieId = "5"
                        });
                });

            modelBuilder.Entity("Moviepedia.Models.MovieInfo", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BoxOffice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReleaseYear")
                        .HasColumnType("int");

                    b.Property<string>("StoryLine")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MovieInfos");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            BoxOffice = "$2.195 billion",
                            Category = "Romance",
                            ReleaseYear = 1997,
                            StoryLine = "After winning a trip on the RMS Titanic during a dockside card game, American Jack Dawson spots the society girl Rose DeWitt Bukater who is on her way to Philadelphia to marry her rich snob fiancé Caledon Hockley. Rose feels helplessly trapped by her situation and makes her way to the aft deck and thinks of suicide until she is rescued by Jack. Cal is therefore obliged to invite Jack to dine at their first-class table where he suffers through the slights of his snobbish hosts. In return, he spirits Rose off to third-class for an evening of dancing, giving her the time of her life. Deciding to forsake her intended future all together, Rose asks Jack, who has made his living making sketches on the streets of Paris, to draw her in the nude wearing the invaluable blue diamond Cal has given her. Cal finds out and has Jack locked away. Soon afterwards, the ship hits an iceberg and Rose must find Jack while both must run from Cal even as the ship sinks deeper into the freezing water."
                        },
                        new
                        {
                            Id = "2",
                            BoxOffice = "$327.3 million",
                            Category = " Psychological crime thriller",
                            ReleaseYear = 1995,
                            StoryLine = "A film about two homicide detectives' (Morgan Freeman and Brad Pitt) desperate hunt for a serial killer who justifies his crimes as absolution for the world's ignorance of the Seven Deadly Sins. The movie takes us from the tortured remains of one victim to the next as the sociopathic 'John Doe' (Kevin Spacey) sermonizes to Detectives Somerset and Mills -- one sin at a time. The sin of Gluttony comes first and the murderer's terrible capacity is graphically demonstrated in the dark and subdued tones characteristic of film noir. The seasoned and cultured but jaded Somerset researches the Seven Deadly Sins in an effort to understand the killer's modus operandi while the bright but green and impulsive Detective Mills (Pitt) scoffs at his efforts to get inside the mind of a killer..."
                        },
                        new
                        {
                            Id = "3",
                            BoxOffice = "$654.3 million",
                            Category = "Fantasy",
                            ReleaseYear = 2003,
                            StoryLine = "William Turner, a resourceful young blacksmith, teams up with the eccentric pirate 'Captain' Jack Sparrow to save his love, the Governor's daughter, Elizabeth Swann, who has been mistakenly captured by the clever and treacherous Barbossa, a former ally of Jack, to make a blood sacrifice so as to end the curse that has been casted upon him and his crew. Will and Jack steal a ship from the Royal Navy and arrive at Tortuga, a pirate port. There Jack meets his friend Joshamee Gibbs and with a buccaneer and 'able bodied' crew, set sail to save Elizabeth and take back the Black Pearl. Meanwhile, Barbossa discovers that not Elizabeth's but someone else's blood was required for the sacrifice. Whose blood is it?"
                        },
                        new
                        {
                            Id = "4",
                            BoxOffice = "$58.3 million",
                            Category = "Drama",
                            ReleaseYear = 1994,
                            StoryLine = "Bank Merchant Andy Dufresne is convicted of the murder of his wife and her lover, and sentenced to life imprisonment at Shawshank prison. Life seems to have taken a turn for the worse, but fortunately Andy befriends some of the other inmates, in particular a character known only as Red. Over time Andy finds ways to live out life with relative ease as one can in a prison, leaving a message for all that while the body may be locked away in a cell, the spirit can never be truly imprisoned."
                        },
                        new
                        {
                            Id = "5",
                            BoxOffice = "$2.79 billion",
                            Category = "Epic Science Fiction",
                            ReleaseYear = 2009,
                            StoryLine = "When his brother is killed in a robbery, paraplegic Marine Jake Sully decides to take his place in a mission on the distant world of Pandora. There he learns of greedy corporate figurehead Parker Selfridge's intentions of driving off the native humanoid 'Na'vi' in order to mine for the precious material scattered throughout their rich woodland. In exchange for the spinal surgery that will fix his legs, Jake gathers knowledge, of the Indigenous Race and their Culture, for the cooperating military unit spearheaded by gung-ho Colonel Quaritch, while simultaneously attempting to infiltrate the Na'vi people with the use of an 'avatar' identity. While Jake begins to bond with the native tribe and quickly falls in love with the beautiful alien Neytiri, the restless Colonel moves forward with his ruthless extermination tactics, forcing the soldier to take a stand - and fight back in an epic battle for the fate of Pandora."
                        });
                });

            modelBuilder.Entity("Moviepedia.Models.Review", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovieId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Moviepedia.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Moviepedia.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Moviepedia.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Moviepedia.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Moviepedia.Models.Movie", b =>
                {
                    b.HasOne("Moviepedia.Models.MovieInfo", "MovieInfo")
                        .WithOne("Movie")
                        .HasForeignKey("Moviepedia.Models.Movie", "MovieInfoId");
                });

            modelBuilder.Entity("Moviepedia.Models.MovieActors", b =>
                {
                    b.HasOne("Moviepedia.Models.Actor", "Actor")
                        .WithMany("MovieActors")
                        .HasForeignKey("ActorId");

                    b.HasOne("Moviepedia.Models.Movie", "Movie")
                        .WithMany("MovieActors")
                        .HasForeignKey("MovieId");
                });

            modelBuilder.Entity("Moviepedia.Models.Review", b =>
                {
                    b.HasOne("Moviepedia.Models.Movie", "Movie")
                        .WithMany("Reviews")
                        .HasForeignKey("MovieId");

                    b.HasOne("Moviepedia.Models.ApplicationUser", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
