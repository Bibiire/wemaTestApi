using Microsoft.EntityFrameworkCore;

namespace wemaTestApi.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Lga> Lgas { get; set; }


    }
}
