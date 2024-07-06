

using System.ComponentModel.DataAnnotations;

namespace Checker.Models
{
    public class LoginModel
    {
        [Required]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string ?email { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters long")]
        public string ?password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [Compare("password", ErrorMessage = "Passwords do not match")]
        public string ?confirmPassword { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Only letters are allowed.")]
        public string ?firstName { get; set; }
        
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Only letters are allowed.")]
        [Required]
        public string ?lastName { get; set; }

        [Required]
        public string ?username { get; set; }
        
    }
}