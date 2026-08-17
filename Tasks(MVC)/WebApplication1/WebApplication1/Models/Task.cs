using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Task
    {
        public int ManagerId { get; set; }
        public Manager? Manager { get; set; }

        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }

        [Required]
        public required string Title { get; set; }
        public DateTime StartDate { get; set; } 

        [Required]
        public DateTime DueDate { get; set; }
        public string? Description { get; set; }
        public string? ImportanceLevel { get; set; }
    }
}
