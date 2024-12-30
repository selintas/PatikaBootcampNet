using Microsoft.EntityFrameworkCore;

namespace CodeFirstMsSql.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<StudentEntity> Students { get; set; } // StudentEntity yapılarının tutulacağı veritablonuzun adını Students olarak belirlediniz.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // @ -> ters slash sorun yaratmasın diye.

            // Windows Authentication için
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=1234;Database=CodeFirstDB");

            // Sql Server Authentication için
            // optionsBuilder.UseSqlServer(@"server=SrtnWorkBook-2; database=PatikaFirstDB; uid=sa; pwd=sa; TrustServerCertificate=true");


            base.OnConfiguring(optionsBuilder);
        }
    }
}
