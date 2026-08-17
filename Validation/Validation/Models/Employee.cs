using System.ComponentModel.DataAnnotations;

namespace Validation.Models
{
    public class Employee
    {
        [Required]
        public int Id { get; set; }
        [Required,
         MaxLength(50, ErrorMessage = "Max length of Name is 50 characters")]
        public required string Name { get; set; }
        [Required,EmailAddress]
        public required string Email { get; set; }
        [Range(1,100, ErrorMessage = "Age must be between 1 and 100")]
        public int? Age { get; set; }
        [Required,Range(1,2000, ErrorMessage = "Salary must be between 1 and 2000")]
        public decimal Salary { get; set; } = 1;
    }
}
