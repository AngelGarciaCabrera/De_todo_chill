using De_Tod_chill.Datos.Entities.Cliente;
using Microsoft.EntityFrameworkCore;

namespace De_Tod_chill.Context
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options): base(options)

        {

        }
<<<<<<< HEAD

        public DbSet<Cliente> Clientes
=======
        public DbSet<customers> Clientes
>>>>>>> Rama-testdb
        {
            set;get;
        }


    }
}
