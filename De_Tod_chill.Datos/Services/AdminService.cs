using Microsoft.EntityFrameworkCore;

namespace De_Tod_chill.Datos.Services;

public class AdminService : GenericService<AdminsDto, int>
{

    private readonly DbContext context;

    public AdminService(DbContext ctx)
    {
        context = ctx;
    }
    
    public AdminsDto Create(AdminsDto t)
    {
        throw new NotImplementedException();
    }

    public AdminsDto Update(AdminsDto t)
    {
        throw new NotImplementedException();
    }

    public AdminsDto Get(int id)
    {
        throw new NotImplementedException();
    }

    public ICollection<AdminsDto> Get()
    {
        throw new NotImplementedException();
    }

    public AdminsDto Delete(int id)
    {
        throw new NotImplementedException();
    }
}