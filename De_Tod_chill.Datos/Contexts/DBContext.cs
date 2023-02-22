using De_Tod_chill.Datos.Entities;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace De_Tod_chill.Datos.Contexts;

public class DBContext : DbContext
{

    public DbSet<User> dbUser { set; get; }
    
}