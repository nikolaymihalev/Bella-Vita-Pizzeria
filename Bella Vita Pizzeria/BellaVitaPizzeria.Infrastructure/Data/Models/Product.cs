using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BellaVitaPizzeria.Infrastructure.Data.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        public string? Description { get; set; }

        [Required]
        public byte[] Image { get; set; } = new byte[128];

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public double MinimumPrice { get; set; }

        public double? MiddlePrice { get; set; }

        public double? MaximumPrice { get; set; }

        [Required]
        public string MinimumWeight { get; set; } = string.Empty;

        public string? MiddleWeight { get; set; }

        public string? MaxmimumWeight { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;
    }
}
