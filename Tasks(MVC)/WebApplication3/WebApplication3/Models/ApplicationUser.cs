using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public required int Age { get; set; }
    }

}
