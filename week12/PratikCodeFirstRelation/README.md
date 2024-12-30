# Code First Relation

Bu proje, Entity Framework Core kullanarak **Code First Yaklaşımı** ile bir veritabanı oluşturma ve tablo ilişkilerini tanımlama örneğidir. Veritabanında bir **User** tablosu ve bir **Post** tablosu bulunmaktadır. Tablolar arasında bir **bire-çok (one-to-many)** ilişki tanımlanmıştır.

## Proje İçeriği

### User Tablosu
- **Id**: `int` (Birincil anahtar ve otomatik artan)
- **Username**: `string` (Kullanıcının kullanıcı adı)
- **Email**: `string` (Kullanıcının e-posta adresi)

### Post Tablosu
- **Id**: `int` (Birincil anahtar ve otomatik artan)
- **Title**: `string` (Gönderinin başlığı)
- **Content**: `string` (Gönderinin içeriği)
- **UserId**: `int` (Gönderinin yazarı, kullanıcının kimliği)

### İlişki
- Bir kullanıcının birden fazla gönderisi olabilir.
- Her gönderi yalnızca bir kullanıcıya ait olabilir.

## Kullanılan Teknolojiler
- **C#**
- **Entity Framework Core**
- **Npgsql** (PostgreSQL için EF Core sağlayıcısı)

## DbContext Sınıfı
`PatikaSecondDbContext` sınıfı, veritabanı bağlantısını ve tablo ilişkilerini tanımlar.

```csharp
using Microsoft.EntityFrameworkCore;

public class PatikaSecondDbContext : DbContext
{
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<PostEntity> Posts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Database=PatikaCodeFirstDb2;Username=yourUsername;Password=yourPassword");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PostEntity>()
            .HasOne(p => p.User)
            .WithMany(u => u.Posts)
            .HasForeignKey(p => p.UserId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
```

## Model Sınıfları

### UserEntity
```csharp
public class UserEntity
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public List<PostEntity> Posts { get; set; }
}
```

### PostEntity
```csharp
public class PostEntity
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public int UserId { get; set; }
    public UserEntity User { get; set; }
}
```

## Migration ve Veritabanı Güncelleme

### 1. Migration Oluşturma
Yeni bir migration oluşturmak için şu komutu çalıştırın:
```bash
dotnet ef migrations add InitialCreate
```

### 2. Veritabanını Güncelleme
Migration'ı veritabanına uygulamak için:
```bash
dotnet ef database update
```

## Örnek Kullanım

### Yeni Kullanıcı ve Gönderi Ekleme
Aşağıdaki kod, yeni bir kullanıcı ve bu kullanıcıya ait gönderiler eklemek için kullanılır:

```csharp
using (var context = new PatikaSecondDbContext())
{
    var user = new UserEntity
    {
        Username = "john_doe",
        Email = "john.doe@example.com",
        Posts = new List<PostEntity>
        {
            new PostEntity { Title = "First Post", Content = "This is the content of the first post." },
            new PostEntity { Title = "Second Post", Content = "This is the content of the second post." }
        }
    };

    context.Users.Add(user);
    context.SaveChanges();
}
```

## Gerekli NuGet Paketleri

### Paketleri Yüklemek İçin:
```bash
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
```

## Veritabanını Kontrol Etme
Migration ve güncelleme işlemi tamamlandıktan sonra PostgreSQL veritabanınızda şu tablolar oluşturulacaktır:

1. **Users**: Kullanıcı bilgilerini saklar.
2. **Posts**: Gönderi bilgilerini saklar ve `UserId` sütunu üzerinden `Users` tablosuyla ilişkilendirilmiştir.

---
![Screenshot (866)](https://github.com/user-attachments/assets/7a6cb91e-0dc5-4633-a483-d9193deb9376)

