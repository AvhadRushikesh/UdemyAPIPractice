using Microsoft.EntityFrameworkCore;

namespace UdemyAPIPractice.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options) 
        {
            
        }
    }
}
