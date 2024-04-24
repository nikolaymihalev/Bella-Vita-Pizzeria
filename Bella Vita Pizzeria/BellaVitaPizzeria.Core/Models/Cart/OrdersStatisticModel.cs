namespace BellaVitaPizzeria.Core.Models.Cart
{
    public class OrdersStatisticModel
    {
        public Dictionary<int, int> MonthsCounts { get; set; } = new Dictionary<int, int>();
    }
}
