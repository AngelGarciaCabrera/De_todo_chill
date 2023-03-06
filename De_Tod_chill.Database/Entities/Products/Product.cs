namespace De_Tod_chill.Database.Entities.Products
{
    public class Product
    {
        public Product()
        {
           

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        [MaxLength(100)][MinLength(2)]
        public string Description { get; set; }
        public string Category { get; set; }

    }
}
