using De_Tod_chill.Datos.Entities;
using De_Tod_chill.Datos.Entities.Customers;

namespace De_Tod_chill.Datos;

public class Program
{
    public static void Main()
    {
        List<IClient<object>> clientes = new List<IClient<object>>();

        IClient<string> admin = new Admin();
        // clientes.Add(admin);
    }
}