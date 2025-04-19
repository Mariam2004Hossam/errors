using Microsoft.EntityFrameworkCore;
using TechXpress.Models;

namespace TechXpress.Data
{
    public class TechXpressDbContext : DbContext
    {
        public TechXpressDbContext(DbContextOptions<TechXpressDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        // Add other DbSets for different models
    }
}
