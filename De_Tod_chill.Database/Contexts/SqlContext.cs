using De_Tod_chill.Database.Entities.Customers;
using Microsoft.EntityFrameworkCore;

namespace De_Tod_chill.Database.Contexts;

public class SqlContext : DbContext
{
    public SqlContext(DbContextOptions options) : base(options)
    {
    }
    
    public DbSet<Customer> Customers { set; get; }
}