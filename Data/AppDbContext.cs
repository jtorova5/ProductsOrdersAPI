using Microsoft.EntityFrameworkCore;

namespace ProductsOrdersAPI.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options) { }
}
