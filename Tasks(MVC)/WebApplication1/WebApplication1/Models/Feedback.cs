using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Feedback
    {
        public int Id { get; set; }

        [Required]
        public required string Title { get; set; }

        [Required]
        public required string Content { get; set; }

    }
}
