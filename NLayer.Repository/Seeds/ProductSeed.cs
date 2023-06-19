using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, Name = "Kalem 1", CategoryId = 1, Stock = 12, Price = 100, CreatedDate = DateTime.Now },
                new Product { Id = 2, Name = "Kalem 2", CategoryId = 1, Stock = 5, Price = 85, CreatedDate = DateTime.Now },
                new Product { Id = 3, Name = "Kitap 1", CategoryId = 2, Stock = 8, Price = 450, CreatedDate = DateTime.Now },
                new Product { Id = 4, Name = "Kitap 2", CategoryId = 2, Stock = 7, Price = 600, CreatedDate = DateTime.Now }
                );
        }
    }
}
