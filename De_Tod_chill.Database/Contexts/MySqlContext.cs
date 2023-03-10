using Microsoft.EntityFrameworkCore;

namespace De_Tod_chill.Database.Contexts;

public class MySqlContext : MainContext
{
    public MySqlContext(DbContextOptions options) : base(options)
    {
    }
}