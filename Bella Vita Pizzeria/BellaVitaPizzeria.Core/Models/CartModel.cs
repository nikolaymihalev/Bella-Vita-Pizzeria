namespace BellaVitaPizzeria.Core.Models
{
    public class CartModel
    {
        public string UserId { get; set; }
        public double Sum { get; set; }
        public IEnumerable<PurchaseModel> Purchases { get; set; } = new List<PurchaseModel>();
    }
}
