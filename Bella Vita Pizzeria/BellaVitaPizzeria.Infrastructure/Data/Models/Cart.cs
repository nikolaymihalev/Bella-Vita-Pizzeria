using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BellaVitaPizzeria.Infrastructure.Data.Models
{
    [Comment("Client's cart")]
    public class Cart
    {
        [Comment("Client identifier")]
        [Key]
        public string UserId { get; set; } = string.Empty;

        [Comment("Order sum")]
        [Required]
        public double Sum { get; set; }

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; }
        public IList<Purchase> Purchases { get; set; } = new List<Purchase>();
    }
}
