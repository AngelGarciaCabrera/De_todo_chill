using De_Tod_chill.Database.Entities.Admins;
using De_Tod_chill.Database.Entities.Customers;
using De_Tod_chill.Database.Entities.Products;
using De_Tod_chill.Database.Entities.Requests;
using Microsoft.EntityFrameworkCore;

namespace De_Tod_chill.Database.Contexts;

public class MainContext : DbContext
{
    public MainContext(DbContextOptions options) : base(options)
    {
    }
    
    public DbSet<Customer> Customers { set; get; }
    public DbSet<Product> Products { set; get; }
    public DbSet<Admin> Admins { set; get; }
    public DbSet<Request> Requests { set; get; }
}