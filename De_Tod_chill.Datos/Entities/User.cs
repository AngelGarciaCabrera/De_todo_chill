using De_Tod_chill.Datos.Entities.Cliente;

namespace De_Tod_chill.Datos.Entities;

public class User : IClient<int> 
{
    public int Id { set; get; }
    public string Name { set; get; }
    public string Rol { get; set; }
    public string Correo { get; set; }

    public User(int id)
    {
        Id = id;
    }

    public int GetId()
    {
        return Id;
    }
}