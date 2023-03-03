using Microsoft.EntityFrameworkCore;

namespace De_Tod_chill.Database.Contexts;


public class MySqlContext : DbContext
{
    public MySqlContext(DbContextOptions options) : base(options)
    {
       
    }

   
}