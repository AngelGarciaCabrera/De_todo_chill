using De_Tod_chill.Datos.Entities;

namespace De_Tod_chill.Datos;

public class Program
{
    public static void Main()
    {
        List<ICliente<object>> clientes = new List<ICliente<object>>();

        ICliente<string> admin = new Admin();
        // clientes.Add(admin);
    }
}