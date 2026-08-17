
namespace Category_Product_Management.DTOs
{
    public class CategoryDTO
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required string ImagePath { get; set; }
        public ICollection<int> ProductIds { get; set; } = new List<int>();
    }
}
