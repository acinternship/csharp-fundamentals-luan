using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Test.Entities
{
    public class TestDbContext : DbContext
        
    {
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
