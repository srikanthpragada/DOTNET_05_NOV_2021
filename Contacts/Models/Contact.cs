using System.ComponentModel.DataAnnotations;

namespace Contacts.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30)]
        [Required]
        public string Fullname { get; set; }

        [MaxLength(50)]
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [MaxLength(10)]
        [RegularExpression(@"\d{10}", ErrorMessage = "Invalid mobile number")]
        public string? Mobile { get; set; }
        public string? UserId { get; set; }  // UserId of the owner
    }
}
