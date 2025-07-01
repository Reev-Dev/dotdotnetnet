using System;
using System.ComponentModel.DataAnnotations;

namespace PEMBEKALAN.Models
{
    public class ProductCategory
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(100)]
        public required string Name { get; set; }
    }
}