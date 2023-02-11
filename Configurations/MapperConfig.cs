using AutoMapper;
using UdemyAPIPractice.Data;
using UdemyAPIPractice.Model.Country;
using UdemyAPIPractice.Model.Hotel;

namespace UdemyAPIPractice.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Country, CreateCountryDto>().ReverseMap();    // For POST
            CreateMap<Country, GetCountryDto>().ReverseMap();       // For GET
            CreateMap<Country, CountryDto>().ReverseMap();          // Country Mappping to CountryDto - For Get/ID
            CreateMap<Hotel, HotelDto>().ReverseMap();              // Hotel Mappint to HotelDto - For Hotel List
        }
    }
}
