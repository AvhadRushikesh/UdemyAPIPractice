using Microsoft.Build.Framework;

namespace UdemyAPIPractice.Model.Country
{
    public abstract class BaseCountryDto
    {
        // public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}
