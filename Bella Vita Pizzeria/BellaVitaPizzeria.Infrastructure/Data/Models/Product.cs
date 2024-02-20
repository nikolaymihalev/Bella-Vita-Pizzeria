using BellaVitaPizzeria.Infrastructure.Data.Constants;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BellaVitaPizzeria.Infrastructure.Data.Models
{
    [Comment("Таблица за продукта")]
    public class Product
    {
        [Key]
        [Comment("Идентификатор на продукта")]
        public int Id { get; set; }
       
        
        [Required]
        [MaxLength(ValidationConstants.ProductTitleMaxLength)]
        [Comment("Име на продукта")]
        public required string Title { get; set; }

        [Required]
        [Comment("Съставки на продукта")]
        [MaxLength(ValidationConstants.ProductIngredientsMaxLength)]
        public required string Ingredients { get; set; }

        [Required]
        [Comment("Идентификатор на категорията на продукта")]
        public int CategoryId { get; set; }

        [Comment("Тегло на продукта")]
        public int Weight { get; set; } 

        [Required]
        [Comment("Цена на продукта")]
        public decimal Price { get; set; }
        
        [Comment("Цена за продукт(пица) голяма")]
        public decimal PriceForPizzaBig { get; set; }
        
        [Comment("Цена за продукт(пица) семейна")]
        public decimal PriceForPizzaFamily { get; set; }

        [Required]
        [Comment("Снимка на продукта")]
        public required string ImageUrl { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }

        public IList<ProductBuyer> ProductsBuyers { get; set; } = new List<ProductBuyer>();
    }
}
