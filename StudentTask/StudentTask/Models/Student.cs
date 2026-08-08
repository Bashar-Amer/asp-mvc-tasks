using System.ComponentModel.DataAnnotations;

namespace StudentTask.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; }

        [Range(1,100)]
        public int? Age { get; set; }
    }
}
