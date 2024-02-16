using System.ComponentModel.DataAnnotations;

namespace Presentation.Authentication.ViewModels
{
    public class RegisterModel
    {
        [Required]
        [MinLength(2)]
        [MaxLength(40)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(40)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string CountryCode { get; set; }

        [Required]
        public ICollection<string> LanguageCodes { get; set; }

        [Required]
        public ICollection<string> TargetLanguageCodes { get; set; }

        [Required]
        public byte Gender { get; set; }

        public string Origin { get; set; }
    }
}
