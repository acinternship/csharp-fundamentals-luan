using Microsoft.EntityFrameworkCore;

namespace Blog.Models
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {

        }
        public DbSet<BlogPost> Posts { get; set; }
    }
}