using System.ComponentModel.DataAnnotations;

namespace BellaVitaPizzeria.Infrastructure.Data.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public IEnumerable<Product> Products { get; set; } = new List<Product>();
    }
}
