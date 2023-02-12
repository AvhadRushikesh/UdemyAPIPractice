using UdemyAPIPractice.Contracts;
using UdemyAPIPractice.Data;

namespace UdemyAPIPractice.Repository
{
    public class CountriesRepository : GenericRepository<Country>, ICountriesRepository
    {
        public CountriesRepository(HotelListingDbContext context) : base(context)
        {

        }
    }
}
