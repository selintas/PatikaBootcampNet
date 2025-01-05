
using Microsoft.EntityFrameworkCore;
using Survivor.Models;

namespace Survivor.Data
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
        }
    }
}
