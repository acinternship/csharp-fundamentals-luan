using Microsoft.EntityFrameworkCore;

namespace Test.Entities
{
    public class TestDbContext : DbContext
        
    {
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
