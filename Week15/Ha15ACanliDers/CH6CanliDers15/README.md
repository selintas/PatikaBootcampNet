# CH6 - Canlı Ders 15

## Generic Repository Pattern ve Katmanlı Mimari (Basitleştirilmiş)

### MarketApp.DAL
- Entities
  - BaseEntity
  - Category
  - Product
- Context
  - Configuration
	- CategoryConfiguration
	- ProductConfiguration
  - ApplicationDbContext
- Migrations
- Repository 
  - IRepository
  - EfRepository

### MarketApp.Business
- Dtos
  - ProductDto
- Interfaces
  - IProductService
- Services
  - ProductService

### MarketApp.API
- appsettings.json
- Program.cs
- Controllers
  - ProductsController
	- GetProducts

### Seed Data
#### Categories
```
new Category { Id = 1, Name = "İçecekler" },
new Category { Id = 2, Name = "Baharatlar" },
new Category { Id = 3, Name = "Tatlılar" },
new Category { Id = 4, Name = "Süt Ürünleri" }
```
#### Products
```
new Product { Id = 1,  Name = "Çay",            Price = 15.00m, CategoryId = 1 },
new Product { Id = 2,  Name = "Kahve",          Price = 18.50m, CategoryId = 1 },
new Product { Id = 3,  Name = "Portakal Suyu",  Price = 12.00m, CategoryId = 1 },
new Product { Id = 4,  Name = "Şeftali Nektarı",Price = 14.00m, CategoryId = 1 },
new Product { Id = 5,  Name = "Maden Suyu",     Price = 8.50m,  CategoryId = 1 },
new Product { Id = 6,  Name = "Limonata",       Price = 11.00m, CategoryId = 1 },
new Product { Id = 7,  Name = "Pul Biber",      Price = 5.00m,  CategoryId = 2 },
new Product { Id = 8,  Name = "Kekik",          Price = 3.00m,  CategoryId = 2 },
new Product { Id = 9,  Name = "Karabiber",      Price = 6.50m,  CategoryId = 2 },
new Product { Id = 10, Name = "Kimyon",         Price = 4.75m,  CategoryId = 2 },
new Product { Id = 11, Name = "Nane",           Price = 2.85m,  CategoryId = 2 },
new Product { Id = 12, Name = "Sumak",          Price = 3.50m,  CategoryId = 2 },
new Product { Id = 13, Name = "Baklava",        Price = 25.00m, CategoryId = 3 },
new Product { Id = 14, Name = "Lokum",          Price = 15.00m, CategoryId = 3 },
new Product { Id = 15, Name = "Revani",         Price = 12.00m, CategoryId = 3 },
new Product { Id = 16, Name = "Kazandibi",      Price = 10.00m, CategoryId = 3 },
new Product { Id = 17, Name = "Şekerpare",      Price = 11.50m, CategoryId = 3 },
new Product { Id = 18, Name = "Künefe",         Price = 20.00m, CategoryId = 3 },
new Product { Id = 19, Name = "Beyaz Peynir",   Price = 35.00m, CategoryId = 4 },
new Product { Id = 20, Name = "Kaşar Peynir",   Price = 45.00m, CategoryId = 4 },
new Product { Id = 21, Name = "Tereyağı",       Price = 40.00m, CategoryId = 4 },
new Product { Id = 22, Name = "Yoğurt",         Price = 12.00m, CategoryId = 4 },
new Product { Id = 23, Name = "Ayran",          Price = 5.00m,  CategoryId = 4 },
new Product { Id = 24, Name = "Labne",          Price = 16.00m, CategoryId = 4 }
```

### Packages

#### MarketApp.DAL
```
Install-Package Microsoft.EntityFrameworkCore -v 8.0.11
Install-Package Microsoft.EntityFrameworkCore.Tools -v 8.0.11
Install-Package Microsoft.EntityFrameworkCore.SqlServer -v 8.0.11
```

#### MarketApp.WebApi
```
Install-Package Microsoft.EntityFrameworkCore.Design -v 8.0.11
```

### Connection String (appsettings.json)
```
"ConnectionStrings": {
	"ApplicationDbContext": "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=MarketAppDb; Trusted_Connection=true"
}
```

### Program.cs
```
builder.Services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddDbContext<ApplicationDbContext>(o => o.UseSqlServer(
    builder.Configuration.GetConnectionString("ApplicationDbContext")
    ));
```

### Migrations
**Default project:** MarketApp.DAL\
**Startup project:** MarketApp.API
```
Add-Migration InitialCreate -o Migrations
Update-Database
```

### IRepository
```
public interface IRepository<T> where T : BaseEntity
{
    T Add(T entity);

    void Delete(T entity);

    void Update(T entity);

    T? GetById(int id);

    T? FirstOrDefault(Expression<Func<T, bool>> predicate);

    List<T> GetAll();

    List<T> GetAll(Expression<Func<T, bool>> predicate);
}
```