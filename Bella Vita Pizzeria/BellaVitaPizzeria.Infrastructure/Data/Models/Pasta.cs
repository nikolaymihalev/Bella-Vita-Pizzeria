using BellaVitaPizzeria.Infrastructure.Data.Constants;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellaVitaPizzeria.Infrastructure.Data.Models
{
    [Comment("Таблица за продукта")]
    public class Pasta
    {
        [Key]
        [Comment("Идентификатор на продукта")]
        public int Id { get; set; }

        [Required]
        [MaxLength(ValidationConstants.PastaTitleMaxLength)]
        [Comment("Име на продукта")]
        public required string Title { get; set; }

        [Required]
        [Comment("Съставки на продукта")]
        [MaxLength(ValidationConstants.PastaIngredientsMaxLength)]
        public required string Ingredients { get; set; }

        [Required]
        [Comment("Тегло на продукта")]
        public required string Weight { get; set; }

        [Required]
        [Comment("Цена на продукта")]
        public decimal Price { get; set; }

        [Required]
        [Comment("Снимка на продукта")]
        public required byte[] Image { get; set; }
    }
}
