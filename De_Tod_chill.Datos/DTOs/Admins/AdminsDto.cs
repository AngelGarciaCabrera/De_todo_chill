using De_Tod_chill.Database.Entities.Admins;


public class AdminsDto : CustomersDto
{

    public AdminsDto()
    {

    }

    public static implicit operator AdminsDto(Admin c)
    {
        return new AdminsDto()
        {
            Name = c.Customer.Name,
            Email = c.Customer.Email,
            Id = c.Customer.Id,
            PhoneNumber = c.Customer.PhoneNumber,


        };
    }
}

