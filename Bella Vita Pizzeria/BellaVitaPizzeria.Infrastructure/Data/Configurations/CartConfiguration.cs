using BellaVitaPizzeria.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BellaVitaPizzeria.Infrastructure.Data.Configurations
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasKey(x => new { x.PurchaseId, x.UserId });
            builder.HasOne(x => x.Purchase).WithMany(x => x.Carts).OnDelete(DeleteBehavior.Restrict);

            var data = new SeedData();

            builder.HasData(data.BuyerCart);
        }
    }
}
