
using Microsoft.EntityFrameworkCore;

namespace De_Tod_chill.Database.Contexts;

public class SqlContext : MainContext
{
    public SqlContext(DbContextOptions options) : base(options)
    {
    }
}