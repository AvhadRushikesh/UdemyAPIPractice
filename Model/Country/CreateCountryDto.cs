using Microsoft.Build.Framework;

namespace UdemyAPIPractice.Model.Country
{
    public class CreateCountryDto
    {
        [Required]
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}
