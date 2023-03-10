using System.Data;

namespace De_Tod_chill.Datos.Repositories;

public interface IRepository<T, ID> where T : class where ID : struct
{
    // bool Add(T t, string contextName);
    void Add(T entity, string contextName);

    void Update(T entity, string contextName);

    T? Get(ID id, string contextName);
    ICollection<T> Get(string contextName);

    bool Delete(ID id, string contextName);
}