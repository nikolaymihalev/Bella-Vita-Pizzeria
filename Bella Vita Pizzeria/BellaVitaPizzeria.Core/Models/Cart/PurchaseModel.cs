namespace BellaVitaPizzeria.Core.Models.Cart
{
    public class PurchaseModel
    {
        public PurchaseModel(
            int id,
            string title,
            string size,
            string image,
            int quantity,
            double unitPrice,
            string userId)
        {
            Id = id;
            Title = title;
            Size = size;
            Image = image;
            Quantity = quantity;
            UnitPrice = unitPrice;
            UserId = userId;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Size { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double Sum => UnitPrice * Quantity;
        public string UserId { get; set; }
    }
}
