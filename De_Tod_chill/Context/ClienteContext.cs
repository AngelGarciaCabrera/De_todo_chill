using De_Tod_chill.Datos.Entities.Cliente;
using De_Tod_chill.Datos.Entities.Customers;
using Microsoft.EntityFrameworkCore;

namespace De_Tod_chill.Context
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options) : base(options)

        {
        }

        public DbSet<Customers> Clientes { set; get; }
    }
}