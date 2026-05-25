using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Website.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        public string Email { get; set; }
          [Required]
        public DateTime? DOB { get; set; }
        [Required]

        public string Gender { get; set; }
        [Required]

        public string PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }    
        [Required]
        public string Qualification { get; set; }
        [Required]
        public string University { get; set; }
        [Required]
        public string ExperienceYear { get; set; }
        [Required]
        public string CNIC { get; set; }
        [Required]
        public string Skills { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public string Password { get; set; }
      






    }
}
