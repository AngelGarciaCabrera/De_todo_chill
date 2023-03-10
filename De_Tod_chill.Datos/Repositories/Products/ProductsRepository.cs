using De_Tod_chill.Database.Contexts.Factory;
using De_Tod_chill.Database.Entities.Products;
using Microsoft.EntityFrameworkCore;

namespace De_Tod_chill.Datos.Repositories.Products
{
    internal class ProductsRepository : IRepository<Product, int>
    {
        private readonly MainContextFactory _contexts;
        public ProductsRepository(MainContextFactory contextFactory)
        {
            _contexts = contextFactory;
        }

        public void Add(Product entity, string contextName)
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

        public Product? Get(int id, string contextName)
        {
            var context = _contexts.GetContext(contextName);
            return context.Products.Find(id);
        }

        public ICollection<Product> Get(string contextName)
        {
            var context = _contexts.GetContext(contextName);
            return context.Products.ToList();
        }

        public void Update(Product entity, string contextName)
        {
            var context = _contexts.GetContext(contextName);
            var entityRef = context.Entry(entity);
            entityRef.State = EntityState.Modified;
            context.SaveChanges();
        }
    }

}
    
