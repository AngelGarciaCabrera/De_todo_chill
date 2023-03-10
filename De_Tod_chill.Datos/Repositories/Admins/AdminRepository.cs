using De_Tod_chill.Database.Contexts.Factory;
using De_Tod_chill.Database.Entities.Admins;
using Microsoft.EntityFrameworkCore;

namespace De_Tod_chill.Datos.Repositories.Admins;

public class AdminRepository : IRepository<Admin, int>
{

    private readonly MainContextFactory _contexts;


    public AdminRepository(MainContextFactory contextFactory)
    {
        _contexts = contextFactory;
    }

    public void Add(Admin entity, string contextName)
    {
        var context = _contexts.GetContext(contextName);
        // Entity references
        var entityRef = context.Attach(entity);
        entityRef.State = EntityState.Added;
        context.SaveChanges();
    }

    public void Update(Admin entity, string contextName)
    {
        var context = _contexts.GetContext(contextName);
        // Entity references
        var entityRef = context.Entry(entity);
        entityRef.State = EntityState.Modified;
        context.SaveChanges();
    }

    public Admin? Get(int id, string contextName)
    {
        var context = _contexts.GetContext(contextName);
        return context.Admins.Find(id);
    }

    public ICollection<Admin> Get(string contextName)
    {
        var context = _contexts.GetContext(contextName);
        return context.Admins.ToList();
    }

    // todo
    public bool Delete(int id, string contextName)
    {
        return false;
    }
}