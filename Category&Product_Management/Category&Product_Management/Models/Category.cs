using System.ComponentModel.DataAnnotations;

namespace Category_Product_Management.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; }

        [Required]
        public required string ImagePath { get; set; }

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
