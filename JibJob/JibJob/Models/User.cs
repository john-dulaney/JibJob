using System.ComponentModel.DataAnnotations;

namespace JibJob.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string JobsApplied { get; set; }

        [Required]
        public string CurrentJob { get; set; }

        [Required]
        public string JobWatch { get; set; }

    }
}