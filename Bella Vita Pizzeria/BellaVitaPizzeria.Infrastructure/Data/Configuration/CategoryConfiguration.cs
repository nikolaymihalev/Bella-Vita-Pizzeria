using BellaVitaPizzeria.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellaVitaPizzeria.Infrastructure.Data.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        private IEnumerable<Category> initialCategories = new List<Category>() 
        {
                new Category()
                {
                    Id = 1,
                    Name = "Pizza"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Pasta"
                },
                new Category()
                {
                    Id = 3,
                    Name = "Soup"
                },
                new Category()
                {
                    Id = 4,
                    Name = "Grill"
                },
                new Category()
                {
                    Id = 5,
                    Name = "Dessert"
                }
        };

        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(initialCategories);
        }
    }
}
