using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De_Tod_chill.Datos.Entities.Customers
{
    public class Customers

    {
        public Customers()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }

        public string Role { get; set; }
        public string Email { get; set; }

    }
}
