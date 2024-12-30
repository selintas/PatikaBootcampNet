using Microsoft.EntityFrameworkCore;
using PratikCodeFirstRelation.Entities;

namespace PratikCodeFirstRelation.Data
{
    public class PatikaSecondDbContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<PostEntity> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=1234;Database=PatikaCodeFirstDb2");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // User - Post ilişkisinin tanımlanması
            modelBuilder.Entity<PostEntity>()
                .HasOne(p => p.User)          // Her gönderinin bir yazarı vardır
                .WithMany(u => u.Posts)       // Bir kullanıcının birden fazla gönderisi olabilir
                .HasForeignKey(p => p.UserId) // Gönderilerin yazarı UserId ile belirlenir
                .OnDelete(DeleteBehavior.Cascade); // Kullanıcı silinirse, gönderiler de silinir
        }
    }
}
