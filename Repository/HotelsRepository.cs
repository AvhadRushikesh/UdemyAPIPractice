using UdemyAPIPractice.Contracts;
using UdemyAPIPractice.Data;

namespace UdemyAPIPractice.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        public HotelsRepository(HotelListingDbContext context) : base(context)
        {
        }
    }
}
