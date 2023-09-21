﻿using System.ComponentModel.DataAnnotations;

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
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        public byte Gender { get; set; }

        public string Origin { get; set; }
    }
}
