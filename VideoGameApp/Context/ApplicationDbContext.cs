using Microsoft.EntityFrameworkCore;
using VideoGameApp.Entities;

namespace VideoGameApp.Context {

    public class ApplicationDbContext : DbContext {
        public DbSet<VideoGame> VideoGames { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<VideoGame>().ToTable("Video_Game");
            modelBuilder.Entity<VideoGame>(entity => {
                entity.HasKey(e => e.Id);
                entity.Property(x => x.Id)
                    .HasColumnName("Id")
                    .ValueGeneratedOnAdd();

                entity.Property(x => x.Id)
                    .HasColumnName("Name")
                    .HasMaxLength(1000);

                entity.Property(x => x.Id)
                    .HasColumnName("Genre")
                    .HasMaxLength(1000);

                entity.Property(x => x.Id)
                    .HasColumnName("Difficulty");

                entity.Property(x => x.Id)
                    .HasColumnName("Rating");
            });

            AddSeedData(modelBuilder);
        }

        private void AddSeedData(ModelBuilder modelBuilder) {
            modelBuilder.Entity<VideoGame>().HasData(
                new VideoGame() {
                    Id = 1,
                    Name = "Starcraft BroodWar",
                    Genre = "Real-time",
                    Difficulty = 5,
                    Rating = 5
                },
                new VideoGame() {
                    Id = 2,
                    Name = "Starcraft 2",
                    Genre = "Real-time",
                    Difficulty = 3,
                    Rating = 5
                },
                new VideoGame() {
                    Id = 3,
                    Name = "League Of Legends",
                    Genre = "MOBA",
                    Difficulty = 2,
                    Rating = 5
                },
                new VideoGame() {
                    Id = 4,
                    Name = "Dota",
                    Genre = "MOBA",
                    Difficulty = 5,
                    Rating = 5
                }
            );
        }
    }
}