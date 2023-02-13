using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace UdemyAPIPractice.Model.Users
{
    public class ApiUserDto
    {
        [System.ComponentModel.DataAnnotations.Required]
        public string FirstName { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string LastName { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        [EmailAddress]
        public string Email { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        [StringLength(15, ErrorMessage ="Your Password is limited to {2} to {1} character",MinimumLength =6)]
        public string Password { get; set; }
    }
}
