using Microsoft.EntityFrameworkCore;

namespace ECommerce.Api.Orders.Db;

public class OrdersDbContext : DbContext
{
    public DbSet<Order> Orders { get; set; } = null!;

    public OrdersDbContext(DbContextOptions options) : base(options)
    {
    }
}
