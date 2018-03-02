using System.ComponentModel.DataAnnotations;

namespace JibJob.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        [Required]
        public string Name { get; set; }

        public string JobList { get; set; }

        [Required]
        public string CompanyLocation { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Fax { get; set; }

    }
}