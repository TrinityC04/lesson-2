using System;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; } = null!;

        [Required, MaxLength(60)]
        public string Brand { get; set; } = null!;

        [Required, MaxLength(60)]
        public string Category { get; set; } = null!;

        public decimal Price { get; set; }

        [MaxLength(2000)]
        public string? Description { get; set; }

        [MaxLength(255)]
        public string? ImageFileName { get; set; }

        public DateTimeOffset CreatedAt { get; set; }
    }
}
