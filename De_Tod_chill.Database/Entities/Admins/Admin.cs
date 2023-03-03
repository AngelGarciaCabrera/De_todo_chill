using System.ComponentModel.DataAnnotations.Schema;
using De_Tod_chill.Datos.Entities.Customers;

namespace De_Tod_chill.Datos.Entities.Admins;

public class Admin
{
    public Admin()
    {
    }

    public int CustomerId { set; get; }
    
    [ForeignKey("CustomerId")]
    public virtual Customer Customer { set; get; }
}