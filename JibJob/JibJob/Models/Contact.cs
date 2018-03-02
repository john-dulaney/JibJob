using System.ComponentModel.DataAnnotations;

namespace JibJob.Models
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string JobId { get; set; }
        public Jobs Jobs { get; set; }

        [Required]
        public string CompanyId { get; set; }
        public Company Company { get; set; }
    }
}