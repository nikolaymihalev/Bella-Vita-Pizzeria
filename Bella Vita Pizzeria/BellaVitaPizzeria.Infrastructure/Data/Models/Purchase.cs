using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BellaVitaPizzeria.Infrastructure.Data.Models
{
    [Comment("Client's product purchase")]
    public class Purchase
    {
        [Comment("Purchase identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Product title")]
        [Required]
        public string Title { get; set; } = string.Empty;

        [Comment("Product size")]
        [Required]
        public string Size { get; set; } = string.Empty;

        [Comment("Product image")]
        [Required]
        public byte[] Image { get; set; } = new byte[128];

        [Comment("Product quantity")]
        [Required]
        public int Quantity { get; set; } = 1;

        [Comment("Product price")]
        [Required]
        public double UnitPrice { get; set; }

        [Comment("Purchase price")]
        public double Sum => UnitPrice*Quantity;

        public IList<Cart> Carts { get; set; } = new List<Cart>();
    }
}