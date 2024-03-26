namespace BellaVitaPizzeria.Infrastructure.Data.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public byte[] Image { get; set; } = new byte[128];
        public int CategoryId { get; set; }
        public double MinimumPrice { get; set; }
        public double? MiddlePrice { get; set; }
        public double? MaximumPrice { get; set; }
        public string MinimumWeight { get; set; } = string.Empty;
        public string? MiddleWeight { get; set; }
        public string? MaxmimumWeight { get; set; }
    }
}
