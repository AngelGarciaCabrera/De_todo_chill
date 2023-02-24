using De_Tod_chill.Datos.Entities;
using Microsoft.EntityFrameworkCore;

namespace De_Tod_chill.Context
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options): base(options)

        {

        }

        public DbSet<Cliente> Clientes
        {
            set;get;
        }


    }
}
