using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De_Tod_chill.Datos.Entities
{
    internal class Cliente

    {
        public Cliente()
        {

        }
        public string Name { get; set; }
        public int ClienteID { get; set; }

        public string Rol { get; set; }
        public string correo { get; set; }

    }
}
