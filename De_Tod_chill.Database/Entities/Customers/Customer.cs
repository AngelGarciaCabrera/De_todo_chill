using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De_Tod_chill.Datos.Entities.Customers
{
    public class Customer

    {
        public Customer()
        {

        }

        [Key]
        public int Id { get; set; }
        [MaxLength(40)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MinLength(8), MaxLength(12)]
        public string PhoneNumber { set; get; }
    }
}
