namespace BellaVitaPizzeria.Core.Models
{
    public class RatingInfoModel
    {
        public RatingInfoModel(
            int id,
            int productId,
            string productTitle,
            string userId,
            string username,
            int value)
        {
            Id = id;
            ProductId = productId;
            ProductTitle = productTitle;
            UserId = userId;
            Username = username;
            Value = value;
        }
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductTitle { get; set; }
        public string UserId { get; set; }
        public string Username { get; set; }
        public int Value { get; set; }
    }
}
