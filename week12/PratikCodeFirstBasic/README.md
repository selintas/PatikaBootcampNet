# Code First Basic

## Code First Yaklaşımı ile Veri Tabanı Oluşturma
Bu proje, Entity Framework Core kullanılarak Code First yaklaşımı ile bir veritabanı oluşturmayı göstermektedir. Veritabanı, aşağıdaki iki bağımsız tabloyu içermektedir:

### Movie Tablosu
- **Id**: `int`, birincil anahtar ve otomatik artan.
- **Title**: `string`, filmin başlığı.
- **Genre**: `string`, filmin türü (örneğin: "Action", "Comedy", "Drama").
- **ReleaseYear**: `int`, filmin çıkış yılı.

### Game Tablosu
- **Id**: `int`, birincil anahtar ve otomatik artan.
- **Name**: `string`, oyunun adı.
- **Platform**: `string`, oyunun oynandığı platform (örneğin: "PC", "PlayStation", "Xbox").
- **Rating**: `decimal`, oyunun puanı (0 ile 10 arasında).

### Context Sınıfı
- Context sınıfının ismi: **PatikaFirstDbContext**
- Veritabanı ismi: **PatikaCodeFirstDb1**
- Tablolar: **Movies** ve **Games**

---

## Kullanım

### Gerekli Paketler

Projeye başlamadan önce aşağıdaki NuGet paketlerini yükleyin:

- `Microsoft.EntityFrameworkCore`
- `Npgsql.EntityFrameworkCore.PostgreSQL`

### Proje Yapısı

#### Movie Sınıfı
```csharp
public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Genre { get; set; }
    public int ReleaseYear { get; set; }
}
```

#### Game Sınıfı
```csharp
public class Game
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Platform { get; set; }
    public decimal Rating { get; set; }
}
```

#### DbContext Sınıfı
```csharp
using Microsoft.EntityFrameworkCore;

public class PatikaFirstDbContext : DbContext
{
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Game> Games { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // PostgreSQL bağlantı dizesi
        optionsBuilder.UseNpgsql("Host=localhost;Database=PatikaCodeFirstDb1;Username=postgres;Password=yourpassword");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>(entity =>
        {
            entity.ToTable("Movies");
            entity.HasKey(m => m.Id);
            entity.Property(m => m.Id).ValueGeneratedOnAdd();
            entity.Property(m => m.Title).IsRequired().HasMaxLength(200);
            entity.Property(m => m.Genre).IsRequired().HasMaxLength(100);
            entity.Property(m => m.ReleaseYear).IsRequired();
        });

        modelBuilder.Entity<Game>(entity =>
        {
            entity.ToTable("Games");
            entity.HasKey(g => g.Id);
            entity.Property(g => g.Id).ValueGeneratedOnAdd();
            entity.Property(g => g.Name).IsRequired().HasMaxLength(100);
            entity.Property(g => g.Platform).IsRequired().HasMaxLength(50);
            entity.Property(g => g.Rating).IsRequired().HasColumnType("decimal(4, 2)");
        });
    }
}
```

#### Program.cs
```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new PatikaFirstDbContext())
        {
            // Veritabanını oluştur
            context.Database.EnsureCreated();
            Console.WriteLine("Database created successfully!");
        }
    }
}
```

---

### Veritabanını Çalıştırma

1. PostgreSQL sunucusunun çalıştığından emin olun.
2. `PatikaFirstDbContext` içindeki bağlantı dizesini kendi PostgreSQL bilgilerinizle güncelleyin.
3. Programı çalıştırarak veritabanını oluşturun.

Alternatif olarak, **Entity Framework Core Migrations** kullanabilirsiniz:

```bash
# Migration oluşturun
dotnet ef migrations add InitialCreate

# Veritabanını güncelleyin
dotnet ef database update
```

---


### Sonuç
Yukarıdaki adımları izleyerek `PatikaCodeFirstDb1` adlı veritabanını PostgreSQL üzerinde oluşturabilir ve `Movies` ile `Games` tablolarını başarılı bir şekilde kullanabilirsiniz.

![Screenshot (863)](https://github.com/user-attachments/assets/7b44488e-40a8-45e3-b050-64e6cebfe249)

![Screenshot (862)](https://github.com/user-attachments/assets/65bb5b25-8d57-4255-8ffe-d7b44ceb8f5f)
