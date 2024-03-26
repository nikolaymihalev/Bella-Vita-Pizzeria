using BellaVitaPizzeria.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BellaVitaPizzeria.Infrastructure.Data.Configurations
{
    internal class FavoriteProductConfiguration : IEntityTypeConfiguration<FavoriteProduct>
    {
        public void Configure(EntityTypeBuilder<FavoriteProduct> builder)
        {
            var data = new SeedData();

            builder.HasKey(x => new { x.ProductId, x.UserId });
            builder.HasOne(x => x.Product).WithMany(x => x.FavoriteProducts).OnDelete(DeleteBehavior.Restrict);

            builder.HasData(data.FirstFavoriteProduct);
        }
    }
}
