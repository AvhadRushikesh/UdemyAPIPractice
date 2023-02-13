using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UdemyAPIPractice.Data.Configurations;

namespace UdemyAPIPractice.Data
{
    public class HotelListingDbContext : IdentityDbContext<ApiUser>
    {
        public HotelListingDbContext(DbContextOptions options) : base(options) 
        {
            
        }

        // To Generate Auto Created Database and Tables Hotels & Countries we structured in Hotel and Country Class/Entity respectively
        // and then we can add-migration

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        // Seeding is the act of putting default data
        // So what we need to do is define in our DB context that we want to override
        // Write down this override method and add-migration SeededCountriesAndHotel will put this data in Country and Hotel table

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoleConfiguration());       // For RoleConfiguration
            modelBuilder.ApplyConfiguration(new CountryConfiguration());
            modelBuilder.ApplyConfiguration(new HotelConfiguration());
        }
    }
}
