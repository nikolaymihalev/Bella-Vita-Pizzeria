namespace BellaVitaPizzeria.Core.Models
{
    public class FavoriteProductInfoModel
    {
        public FavoriteProductInfoModel(
            int productId,
            string userId,
            ProductInfoModel product)
        {
            ProductId = productId;
            UserId = userId;
            Product = product;
        }
        public int ProductId { get; set; }
        public string UserId { get; set; }
        public ProductInfoModel Product { get; set; }
    }
}
