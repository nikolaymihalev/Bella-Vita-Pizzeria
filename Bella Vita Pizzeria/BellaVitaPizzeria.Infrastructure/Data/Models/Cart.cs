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
        [Required]
        public string UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; }

        [Comment("Purchase identifier")]
        [Required]
        public int PurchaseId { get; set; }

        [ForeignKey(nameof(PurchaseId))]
        public Purchase Purchase { get; set; }
    }
}
