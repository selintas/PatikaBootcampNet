using CodeFirstAraTablo.Data.Entities;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<StudentCourse> StudentCourses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=1234;Database=FirstCodeAraTabloDb");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        ////Studen için ekleme
        //modelBuilder
        //    .Entity<Student>()
        //    .Property(x => x.StudentCourses)
        //    .HasMaxLength(50);

        //// Student için örnek veri ekleme
        //modelBuilder.Entity<Student>().HasData(
        //    new Student() { Id = 1, Name = "Ahmet" },
        //    new Student() { Id = 2, Name = "Mehmet" }
        //    );

        // Ara tabloyu tanımlıyoruz
        modelBuilder.Entity<StudentCourse>()
            .HasKey(sc => new { sc.StudentId, sc.CourseId }); // Birincil anahtar olarak iki sütun
    }
}