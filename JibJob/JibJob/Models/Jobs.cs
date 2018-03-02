using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JibJob.Models
{
    public class Jobs
    {
        [Key]
        public int JobId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public string CompanyId { get; set; }
        public Company Company { get; set; }

        [Required]
        public bool JobAppliedto { get; set; }

        //public virtual ICollection<MovieUser> MovieUsers { get; set; }

    }
}