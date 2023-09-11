using System.ComponentModel.DataAnnotations;

namespace Presentation.Authentication.ViewModels
{
    public class LoginModel
    {
        [Required]
        public string LoginOrEmail { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
