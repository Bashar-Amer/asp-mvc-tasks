using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace WebApplication1.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; }


        public DateTime BirthDate { get; set; }


        public string? PhoneNumber { get; set; }

        [Required]
        public required string NationalId { get; set; }

        [Required]
        public required string Nationality{ get; set; }

        [Required]
        public required int MaritalStatusId{ get; set; }
        public MaritalStatus? MaritalStatus { get; set; }

        public string? PersonalPhotoPath{ get; set; }
        public DateTime EntryDate { get; set; }

        [Required]
        public required string Password { get; set; }


        public required int DepartmentId{ get; set; }
        public Department? Department{ get; set; }

        public ICollection<Task> Tasks { get; set; } = new List<Task>();

    }
}
