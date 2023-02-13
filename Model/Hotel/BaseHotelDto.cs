using System.ComponentModel.DataAnnotations;

namespace UdemyAPIPractice.Model.Hotel
{
    public abstract class BaseHotelDto
    {
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string Address { get; set; }

        public string? Rating { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        [Range(1, int.MaxValue)]
        public int CountryId { get; set; }
    }
}