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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder
                .Property(c => c.Name)
                .HasMaxLength(100);

            builder
                .HasData(
                    new Category { Id = 1, Name = "İçecekler" },
                    new Category { Id = 2, Name = "Baharatlar" },
                    new Category { Id = 3, Name = "Tatlılar" },
                    new Category { Id = 4, Name = "Süt Ürünleri" }
                );
        }
    }
}
