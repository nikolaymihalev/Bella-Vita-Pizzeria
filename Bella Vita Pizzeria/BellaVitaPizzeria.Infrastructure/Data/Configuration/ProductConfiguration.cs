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
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        private IEnumerable<Product> initialProducts = new List<Product>() 
        {
            new Product()
            { 
                Id = 1, 
                CategoryId = 1, 
                Title = "Пица Карбонара", 
                Ingredients = "Пица с домашно приготвено прясно тесто (глутен), сметана (млечен продукт), прошуто кото, кашкавал (млечен продукт), яйце (яйце)",
                Price = 15m,
                PriceForPizzaBig = 16m,
                PriceForPizzaFamily = 43m,
                ImageUrl = "https://cdn4.focus.bg/fakti/photos/big/4cb/recepta-za-vechera-pica-karbonara-1.jpg"
            },
            new Product()
            {
                Id = 2,
                CategoryId = 2,
                Title = "Спагети Болонезе",
                Ingredients = "Прясно сварена паста (глутен), доматен сос, сос Болонезе (кайма, лук моркови), кашкавал (млечен продукт), маслина",
                Price = 15.5m,
                Weight = 400,
                ImageUrl = "https://leonardobansko.bg/wp-content/uploads/2020/07/2020-07-27_13h48_32-601x385.png"
            }
        };

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(e => e.Price).HasPrecision(18, 8);
            builder.Property(e => e.PriceForPizzaBig).HasPrecision(18, 8);
            builder.Property(e => e.PriceForPizzaFamily).HasPrecision(18, 8);

            builder.HasData(initialProducts);
        }
    }
}
