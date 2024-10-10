using Microsoft.EntityFrameworkCore;
using ProductsOrdersAPI.Models;

namespace ProductsOrdersAPI.Data;

public class AppDbContext : DbContext
{
    public DbSet<Category> Categories { get; set; }

    public AppDbContext(DbContextOptions options) : base(options) { }
}
