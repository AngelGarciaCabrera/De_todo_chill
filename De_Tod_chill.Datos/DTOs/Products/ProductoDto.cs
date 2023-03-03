using De_Tod_chill.Database.Entities.Products;

namespace De_Tod_chill.Datos.DTOs.Products;

public class ProductoDto
{
    
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }

    public ProductoDto()
    {
    }
    
    
    // Implicit

    public static implicit operator ProductoDto(Product p)
    {
        return new ProductoDto()
        {
            Id = p.Id,
            Name = p.Name,
            Category = p.Category,
            Description = p.Description,
            Price = p.Price
        };
    }
}