using De_Tod_chill.Database.Entities.Products;

namespace De_Tod_chill.Datos.DTOs.Products;

public class ProductDto
{
    
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }

    public ProductDto()
    {
    }
    
    
    // Implicit

    public static implicit operator ProductDto(Product p)
    {
        return new ProductDto()
        {
            Id = p.Id,
            Name = p.Name,
            Category = p.Category,
            Description = p.Description,
            Price = p.Price
        };
    }
}