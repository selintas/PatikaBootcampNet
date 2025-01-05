using Microsoft.EntityFrameworkCore;
using SurvivorApı.Models;

namespace SurvivorApı.Data
{
    public class SurvivorDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Competitor> Competitors { get; set; }

        public SurvivorDbContext(DbContextOptions<SurvivorDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Competitors)
                .WithOne(co => co.Category)
                .HasForeignKey(co => co.CategoryId);

            modelBuilder.Entity<Category>().HasData(
                 new Category
                 {
                 Id = 1,
                 Name = "Unluler",  // Kategorinin adı
                 CreatedDate = new DateTime(2024, 1, 1, 10, 0, 0), // 2024-01-01 10:00:00
                 UpdatedDate = new DateTime(2024, 1, 1, 10, 0, 0)
                 },
                 new Category
                 {
                     Id = 2,
                     Name = "Gönüllüler",  // Kategorinin adı
                     CreatedDate = new DateTime(2024, 1, 1, 10, 0, 0), // 2024-01-01 10:00:00
                     UpdatedDate = new DateTime(2024, 1, 1, 10, 0, 0),
                     IsDeleted = false,
                 }
             );

            modelBuilder.Entity<Competitor>().HasData(
                new Competitor
                {
                    Id = 1,
                    FirstName = "Acun",
                    LastName = "Ilıcalı",
                    CreatedDate = new DateTime(2024, 1, 1, 10, 0, 0), // 2024-01-01 10:00:00
                    UpdatedDate = new DateTime(2024, 1, 1, 10, 0, 0),
                    IsDeleted = false,
                    CategoryId = 1
                }
            );
        }
    }
}
