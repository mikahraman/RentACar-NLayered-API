using Entities; 
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{

    public class RentACarContext : DbContext
    {

        public RentACarContext(DbContextOptions<RentACarContext> options) : base(options)
        {
        }


        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
    }
}