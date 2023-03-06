using De_Tod_chill.Database.Entities.Customers;
using Microsoft.EntityFrameworkCore;
using De_Tod_chill.Datos.Entities.Admins;
using De_Tod_chill.Datos.Entities.Customers;
using De_Tod_chill.Datos.Entities.Products;
using De_Tod_chill.Datos.Entities.Requests;
using Microsoft.EntityFrameworkCore;

namespace De_Tod_chill.Database.Contexts;

public class MySqlContext : DbContext
{
    public MySqlContext(DbContextOptions options) : base(options)
    {
    }
    
    public DbSet<Customer> Customers { set; get; }
    public DbSet<Product> Products { set; get; }
    public DbSet<Admin> Admins { set; get; }
    public DbSet<Request> Requests { set; get; }
}