using MarketApp.DAL.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApp.DAL.Context.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .Property(p => p.Name)
                .HasMaxLength(200);

            builder
                .Property(p => p.Price)
                .HasPrecision(18, 2);

            builder
                .HasData(
                    new Product { Id = 1, Name = "Çay", Price = 15.00m, CategoryId = 1 },
                    new Product { Id = 2, Name = "Kahve", Price = 18.50m, CategoryId = 1 },
                    new Product { Id = 3, Name = "Portakal Suyu", Price = 12.00m, CategoryId = 1 },
                    new Product { Id = 4, Name = "Şeftali Nektarı", Price = 14.00m, CategoryId = 1 },
                    new Product { Id = 5, Name = "Maden Suyu", Price = 8.50m, CategoryId = 1 },
                    new Product { Id = 6, Name = "Limonata", Price = 11.00m, CategoryId = 1 },
                    new Product { Id = 7, Name = "Pul Biber", Price = 5.00m, CategoryId = 2 },
                    new Product { Id = 8, Name = "Kekik", Price = 3.00m, CategoryId = 2 },
                    new Product { Id = 9, Name = "Karabiber", Price = 6.50m, CategoryId = 2 },
                    new Product { Id = 10, Name = "Kimyon", Price = 4.75m, CategoryId = 2 },
                    new Product { Id = 11, Name = "Nane", Price = 2.85m, CategoryId = 2 },
                    new Product { Id = 12, Name = "Sumak", Price = 3.50m, CategoryId = 2 },
                    new Product { Id = 13, Name = "Baklava", Price = 25.00m, CategoryId = 3 },
                    new Product { Id = 14, Name = "Lokum", Price = 15.00m, CategoryId = 3 },
                    new Product { Id = 15, Name = "Revani", Price = 12.00m, CategoryId = 3 },
                    new Product { Id = 16, Name = "Kazandibi", Price = 10.00m, CategoryId = 3 },
                    new Product { Id = 17, Name = "Şekerpare", Price = 11.50m, CategoryId = 3 },
                    new Product { Id = 18, Name = "Künefe", Price = 20.00m, CategoryId = 3 },
                    new Product { Id = 19, Name = "Beyaz Peynir", Price = 35.00m, CategoryId = 4 },
                    new Product { Id = 20, Name = "Kaşar Peynir", Price = 45.00m, CategoryId = 4 },
                    new Product { Id = 21, Name = "Tereyağı", Price = 40.00m, CategoryId = 4 },
                    new Product { Id = 22, Name = "Yoğurt", Price = 12.00m, CategoryId = 4 },
                    new Product { Id = 23, Name = "Ayran", Price = 5.00m, CategoryId = 4 },
                    new Product { Id = 24, Name = "Labne", Price = 16.00m, CategoryId = 4 }
                );
        }
    }
}
