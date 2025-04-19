using Microsoft.EntityFrameworkCore;
using TechXpress.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    { }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Define relationship between Product and Category
        modelBuilder.Entity<Product>()
            .HasOne(p => p.Category)  // Product has one Category
            .WithMany(c => c.Products) // Category has many Products
            .HasForeignKey(p => p.CategoryId); // Foreign key on Product
    }
}
