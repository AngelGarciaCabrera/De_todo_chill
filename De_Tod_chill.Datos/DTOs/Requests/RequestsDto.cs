using De_Tod_chill.Database.Entities.Products;
using De_Tod_chill.Database.Entities.Requests;

namespace De_Tod_chill.Datos.DTOs.Requests;

public class RequestsDto
{
    public RequestsDto()
    {}

    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public virtual Product Product { set; get; }

    public static implicit operator RequestsDto(Request r)
    {
        return new RequestsDto()
        {
            Id = r.Id,
            Name = r.Name,
            Description = r.Description,
            Product = r.Product,
        };
    }
}