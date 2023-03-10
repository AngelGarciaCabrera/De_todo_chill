using De_Tod_chill.Database.Contexts.Factory;
using De_Tod_chill.Database.Entities.Requests;
using Microsoft.EntityFrameworkCore;

namespace De_Tod_chill.Datos.Repositories.Requests
{
    internal class RequestRepository : IRepository<Request, int>
    {
        private readonly MainContextFactory _contexts;
        public RequestRepository(MainContextFactory contextFactory)
        {
            _contexts = contextFactory;
        }

        public void Add(Request entity, string contextName)
        {
            var context = _contexts.GetContext(contextName);
            var entityRef = context.Attach(entity);
            entityRef.State = EntityState.Added;
            context.SaveChanges();
        }

        public bool Delete(int id, string contextName)
        {
            return false;
        }

        public Request? Get(int id, string contextName)
        {
            var context = _contexts.GetContext(contextName);
            return context.Requests.Find(id);
        }

        public ICollection<Request> Get(string contextName)
        {
            var context = _contexts.GetContext(contextName);
            return context.Requests.ToList();
        }

        public void Update(Request entity, string contextName)
        {
            var context = _contexts.GetContext(contextName);
            var entityRef = context.Entry(entity);
            entityRef.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
}
