namespace BellaVitaPizzeria.Core.Models
{
    public class ProductQueryModel
    {
        public IEnumerable<ProductInfoModel> Products { get; set; } = new List<ProductInfoModel>();
        public int CurrentPage { get; set; }
        public string? Sorting { get; set; }
        public string? Category { get; set; }
        public double PagesCount { get; set; }
    }
}
