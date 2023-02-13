using AutoMapper;
using UdemyAPIPractice.Data;
using UdemyAPIPractice.Model.Country;
using UdemyAPIPractice.Model.Hotel;
using UdemyAPIPractice.Model.Users;

namespace UdemyAPIPractice.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Country, CreateCountryDto>().ReverseMap();    // For POST
            CreateMap<Country, GetCountryDto>().ReverseMap();       // For GET
            CreateMap<Country, CountryDto>().ReverseMap();          // Country Mappping to CountryDto - For Get/ID
            CreateMap<Country, UpdateCountryDto>().ReverseMap();    // For Put Method to Update Table
            
            CreateMap<Hotel, HotelDto>().ReverseMap();              // Hotel Mapping to HotelDto - For Hotel List
            CreateMap<Hotel, CreateHotelDto>().ReverseMap();        // For Creating New Hotel

            CreateMap<ApiUserDto, ApiUser>().ReverseMap();          // For User / Setup Auth Manager for Registration / Security
        }
    }
}
