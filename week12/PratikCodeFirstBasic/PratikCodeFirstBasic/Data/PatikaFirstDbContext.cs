using Microsoft.EntityFrameworkCore;
namespace PratikCodeFirstBasic.Data
{
    public class PatikaFirstDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Game> Games { get; set; } // tablolar oluştur.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=1234;Database=PatikaCodeFirstDb1");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().ToTable("Movies");
            modelBuilder.Entity<Game>().ToTable("Games");

            modelBuilder.Entity<Movie>().HasData(
                new Movie() { Id = 1, Title = "Tatile çık", Genre = "Aksiyon", ReleaseYear = 2012 },
                new Movie() { Id = 2, Title = "Evlen", Genre = "Comedy", ReleaseYear = 2024 },
                new Movie() { Id = 3, Title = "Saygınlık kazan", Genre = "Drama", ReleaseYear =2014 }
                );

            modelBuilder.Entity<Game>().HasData(
                new Game() { Id = 1, Name = "Tatile çık", Platform = "PC", Rating = 10 },
                new Game() { Id = 2, Name = "Evlen", Platform = "PlayStation", Rating = 1 },
                new Game() { Id = 3, Name = "Saygınlık kazan", Platform = "Xbox", Rating = 7}
                );
        }

    }
}
