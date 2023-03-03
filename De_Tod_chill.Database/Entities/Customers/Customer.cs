using System.ComponentModel.DataAnnotations;

namespace De_Tod_chill.Database.Entities.Customers
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
