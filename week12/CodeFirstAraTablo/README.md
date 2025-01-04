

## Code First Yaklaşımında Ara Tablo

### Adım 1: Model Sınıflarını Tanımlama

İlk olarak, iki ana model sınıfı ve bir ara tablo sınıfı oluşturacağız.

#### Student Modeli

```csharp
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    // Öğrencinin aldığı derslerin listesi
    public List<StudentCourse> StudentCourses { get; set; } 
}
```

#### Course Modeli

```csharp
public class Course
{
    public int Id { get; set; }
    public string Title { get; set; }
    
    // Dersin alındığı öğrencilerin listesi
    public List<StudentCourse> StudentCourses { get; set; }
}
```

#### StudentCourse (Ara Tablo) Modeli

```csharp
public class StudentCourse
{
    public int StudentId { get; set; }
    public Student Student { get; set; }

    public int CourseId { get; set; }
    public Course Course { get; set; }
}
```

`StudentCourse` sınıfı, `Student` ve `Course` tabloları arasındaki ilişkiyi temsil eder. Her iki tabloyla da ilişkilidir ve iki anahtar (`StudentId` ve `CourseId`) içerir.

---

### Adım 2: DbContext Sınıfını Oluşturma

DbContext sınıfında, ara tablonun nasıl kullanılacağını tanımlayacağız.

```csharp
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<StudentCourse> StudentCourses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("ConnectionString");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Ara tabloyu tanımlıyoruz
        modelBuilder.Entity<StudentCourse>()
            .HasKey(sc => new { sc.StudentId, sc.CourseId }); // Birincil anahtar olarak iki sütun
    }
}
```

`HasKey` metodu, `StudentCourse` tablosunda iki sütunun birincil anahtar olduğunu belirtir.

#### Not:
- Eğer bir kolonu içerisinde "Id" geçerek tanımlıyorsanız, Entity Framework onun birincil anahtar olduğunu otomatik olarak anlar.
- Ancak, başka bir kolonu (örneğin, "TcKimlikNo") birincil anahtar yapmak isterseniz, `HasKey` metodunu kullanmanız gerekir.
- Çoka çok bağlantılarda **Composite Key** kullanıldığından dolayı, Entity Framework bu yapıyı otomatik anlamaz. Bu yüzden `HasKey` yazmanız gerekir.

---

### Adım 3: Migration ve Veritabanı Güncelleme

#### Migration Ekleyin

Aşağıdaki komut, `Student`, `Course` ve `StudentCourse` tablosunu içeren bir migration dosyası oluşturur:

```bash
dotnet ef migrations add InitialCreate
```

veya

```bash
add-migration InitialCreate
```

#### Veritabanını Güncelleyin

Bu komut, migration'ı veritabanına uygular ve ilgili tablolarda değişiklikler yapar:

```bash
dotnet ef database update
```

veya

```bash
update-database
```

---

## Özet

- `Student`, `Course` ve `StudentCourse` sınıflarını tanımladık.
- Ara tabloyu manuel olarak oluşturduk.
- Ara tablonun birincil anahtarını (Composite Key) DbContext sınıfında tanımladık.
- Eğer BaseClass kullanıyor olsaydık ve bir `Id` kolonu geliyor olsaydı, bu yapıyı `Ignore` ile göz ardı etmemiz gerekirdi.
![Screenshot (867)](https://github.com/user-attachments/assets/528c9c95-6a12-4937-a0de-251a9984ff7d)
