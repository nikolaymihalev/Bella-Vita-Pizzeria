using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellaVitaPizzeria.Infrastructure.Data.Models
{
    [Comment("Таблица за паста")]
    public class Pasta
    {
        [Key]
        [Comment("Идентификатор на пастата")]
        public int Id { get; set; }

        [Required]
        [Comment("Име на пастата")]
        public required string Title { get; set; }

        [Required]
        [Comment("Съставки на паста")]
        public required string Ingredients { get; set; }

        [Required]
        [Comment("Тегло на пастата")]
        public required string Weight { get; set; }

        [Required]
        [Comment("Цена на пастата")]
        public decimal Price { get; set; }

        [Required]
        [Comment("Снимка на пастата")]
        public required byte[] Image { get; set; }
    }
}
