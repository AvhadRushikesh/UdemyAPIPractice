using UdemyAPIPractice.Model.Hotel;

namespace UdemyAPIPractice.Model.Country
{
    // api/countries/5 OR For Get using or Specific ID Method in Controllers
    public class CountryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public List<HotelDto> Hotels { get; set; }   // To get Hotel List when use ID
    }   
}
