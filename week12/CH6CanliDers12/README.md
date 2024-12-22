﻿# CH6 - Canlı Ders 7b

## Microsoft EntityFramework Core

### PACKAGES
```
Install-Package Microsoft.EntityFrameworkCore -v 8.0.11
Install-Package Microsoft.EntityFrameworkCore.Tools -v 8.0.11
Install-Package Npgsql.EntityFrameworkCore.PostgreSQL -v 8.0.11
```

### CONNECTION STRING
```
Host=localhost;Port=5432;Username=postgres;Password=******;Database=dbname
```

### ENTITY CLASS
```
public class Gorev
{
    public int Id { get; set; }

    public string Baslik { get; set; } = "";

    public bool Yapildi { get; set; }
}
```

### DBCONTEXT & SEED DATA
```
public class UygulamaDbContext : DbContext
{
    public DbSet<Gorev> Gorevler { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=******;Database=dbname");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Gorev>().HasData(
            new Gorev() { Id = 1, Baslik = "Kitap oku", Yapildi = false },
            new Gorev() { Id = 2, Baslik = "Spor yap", Yapildi = false },
            new Gorev() { Id = 3, Baslik = "Yemek hazırla", Yapildi = true },
            new Gorev() { Id = 4, Baslik = "Çamaşırları Yıka", Yapildi = true }
            );
    }
}
```

### MIGRATIONS
```
Add-Migration Ilk -o Data/Migrations
Update-Database
```

### Program.cs
```
using (var db = new UygulamaDbContext())
{
    foreach (Gorev gorev in db.Gorevler)
    {
        Console.WriteLine(gorev.Baslik);
    }
}
```

### KAYNAKLAR
- https://learn.microsoft.com/en-us/ef/core/ 
- https://www.npgsql.org/efcore/?tabs=onconfiguring
- https://learn.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-8.0&tabs=visual-studio

# DERS 2

## SQL SERVER ÜZERİNDE ÇALIŞMAK İÇİN

### PACKAGES
```
Install-Package Microsoft.EntityFrameworkCore -v 8.0.11
Install-Package Microsoft.EntityFrameworkCore.Tools -v 8.0.11
Install-Package Microsoft.EntityFrameworkCore.SqlServer -v 8.0.11
```

### CONNECTION STRING
```
server=(localdb)\MSSQLLocalDB;database=AnadoluDb;trusted_connection=true
```