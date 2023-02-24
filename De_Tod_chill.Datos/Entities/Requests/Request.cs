using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using De_Tod_chill.Datos.Entities.Products;

namespace De_Tod_chill.Datos.Entities.Requests
{
    // Peticiones
    public class Request
    {
        public Request()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        // continuar

        // ENTITY FRAMEWORK
        public int ProductId { set; get; }
        public Product Product { set; get; }
    }
}
