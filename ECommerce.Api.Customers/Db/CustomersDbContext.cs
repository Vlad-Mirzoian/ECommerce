using Microsoft.EntityFrameworkCore;

namespace ECommerce.Api.Customers.Db;

public class CustomersDbContext : DbContext
{
    public DbSet<Customer> Customers { get; set; } = null!;

    public CustomersDbContext(DbContextOptions options) : base(options)
    {
    }
}
