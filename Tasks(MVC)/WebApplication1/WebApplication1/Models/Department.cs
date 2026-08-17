using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public sealed class Department
    {
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; }
    }
}
