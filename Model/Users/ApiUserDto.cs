using Microsoft.Build.Framework;

namespace UdemyAPIPractice.Model.Users
{
    public class ApiUserDto : LoginDto
    {
        [System.ComponentModel.DataAnnotations.Required]
        public string FirstName { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string LastName { get; set; }        
    }
}
