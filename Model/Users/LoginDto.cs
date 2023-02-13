using System.ComponentModel.DataAnnotations;

namespace UdemyAPIPractice.Model.Users
{
    public class LoginDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Your Password is limited to {2} to {1} character", MinimumLength = 6)]
        public string Password { get; set; }
    }
}
