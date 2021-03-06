﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingPlanner.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Enter your first name")]
        [MinLength(2, ErrorMessage = "First name must be at least 2 characters")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "first name must be letters only")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Enter your last name")]
        [MinLength(2, ErrorMessage = "Last name must be at least 2 characters")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Last name must be letters only")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Enter your email")]
        [EmailAddress(ErrorMessage = "Enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter a password")]
        [MinLength(8, ErrorMessage = "Must be at least 8 characters")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string Password2 { get; set; }
    }
}
