using Microsoft.EntityFrameworkCore;
using ProductsOrdersAPI.Models;
using ProductsOrdersAPI.Seeders;

namespace ProductsOrdersAPI.Data;

public class AppDbContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }

    public AppDbContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        CategorySeeder.Seed(modelBuilder);
        ProductSeeder.Seed(modelBuilder);
    }
}
