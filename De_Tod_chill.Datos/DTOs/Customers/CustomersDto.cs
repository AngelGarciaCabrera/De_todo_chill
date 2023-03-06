using De_Tod_chill.Database.Entities.Customers;

public class CustomersDto
{

 
    public int Id { get; set; }
   
    public string Name { get; set; }
   
    public string Email { get; set; }
 
    public string PhoneNumber { set; get; }

    public CustomersDto()
	{
	}
    public static implicit operator CustomersDto(Customer c)
    {
        return new CustomersDto()
        {
            Id = c.Id,
           Name = c.Name,
           Email = c.Email,
           PhoneNumber = c.PhoneNumber,
           
        };
    }
}
