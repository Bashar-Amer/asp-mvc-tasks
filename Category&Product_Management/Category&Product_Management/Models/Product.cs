using System.ComponentModel.DataAnnotations;

namespace Category_Product_Management.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; }

        [Required]
        public required string ImagePath { get; set; }

        [Required]
        public required string Description { get; set; }

        [Required]
        public required float Price { get; set; }

        public required int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
