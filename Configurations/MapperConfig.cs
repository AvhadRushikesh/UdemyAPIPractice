using AutoMapper;
using UdemyAPIPractice.Data;
using UdemyAPIPractice.Model.Country;

namespace UdemyAPIPractice.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Country, CreateCountryDto>().ReverseMap();
        }
    }
}
