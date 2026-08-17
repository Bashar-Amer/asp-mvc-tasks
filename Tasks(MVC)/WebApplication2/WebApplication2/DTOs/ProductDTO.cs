using WebApplication2.Models;

namespace WebApplication2.DTOs
{
    public class ProductDTO
    {
        public required string Name { get; set; }
        public required string ImagePath { get; set; }
        public required string CategoryName;
    }
}
