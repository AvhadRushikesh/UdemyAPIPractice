using Microsoft.EntityFrameworkCore;

namespace UdemyAPIPractice.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options) 
        {
            
        }

        // To Generate Auto Created Database and Tables Hotels & Countries we structured in Hotel and Country Class/Entity respectively
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}
