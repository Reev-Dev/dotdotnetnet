using System.ComponentModel.DataAnnotations;

namespace PEMBEKALAN.Models
{
    public class Customer
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(100)]
        public required string Name { get; set; }

        [Required]
        [StringLength(20)]
        public required string Telephone { get; set; }
    }
}