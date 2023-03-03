using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using De_Tod_chill.Datos.Entities.Products;

namespace De_Tod_chill.Datos.Entities.Requests
{
    // Peticiones
    public class Request
    {
        public Request()
        {

        }
        
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MinLength(15), MaxLength(100)]
        public string Description { get; set; }
        
        public int ProductId { set; get; }
        [ForeignKey("ProductId")]
        public virtual Product Product { set; get; }
    }
}
