using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Manager
    {
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; }

        public int DepartmentId { get; set; }
        public Department? Department { get; set; }

        public ICollection<Task> Tasks { get; set; } = new List<Task>();

    }
}
