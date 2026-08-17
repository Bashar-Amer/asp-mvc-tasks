using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public sealed class MaritalStatus
    {
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; }


    }
}
