using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; }

        [Required]
        public required string ImagePath { get; set; }

        public required int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
