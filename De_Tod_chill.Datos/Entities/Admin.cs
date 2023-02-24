﻿using De_Tod_chill.Datos.Entities.Cliente;

namespace De_Tod_chill.Datos.Entities;

public class Admin : ICliente<string>
{
    public string Id { set; get; }
    public string Rol { get; set; }
    public string correo { get; set; }

    public Admin()
    {
    }

    public string GetId()
    {
        return Id;
    }
}