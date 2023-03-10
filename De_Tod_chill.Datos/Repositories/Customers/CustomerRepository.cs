using Microsoft.EntityFrameworkCore;
using De_Tod_chill.Database.Entities.Customers;
using De_Tod_chill.Database.Contexts.Factory;

namespace De_Tod_chill.Datos.Repositories.Customers
{
    internal class CustomerRepository : IRepository<Customer, int>
    {
        private readonly MainContextFactory _Contexts;

        public CustomerRepository(MainContextFactory contextFactory)
        {
            _Contexts = contextFactory;
        }
        public void Add(Customer entity, string contextName)
        {
            var context = _Contexts.GetContext(contextName);
            var entityRef = context.Attach(entity);
            entityRef.State = EntityState.Added;
            context.SaveChanges();
        }

        public bool Delete(int id, string contextName)
        {
           
            return false;
        }

        public Customer? Get(int id, string contextName)
        {
            var context = _Contexts.GetContext(contextName);
            return context.Customers.Find(id);
        }

        public ICollection<Customer> Get(string contextName)
        {
            var context = _Contexts.GetContext(contextName);
            return context.Customers.ToList();
        }

        public void Update(Customer entity, string contextName)
        {
            var context = _Contexts.GetContext(contextName);
            var entityRef = context.Entry(entity);
            entityRef.State = EntityState.Modified;
            context.SaveChanges();

        }
    }
}
