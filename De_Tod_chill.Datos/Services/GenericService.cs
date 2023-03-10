namespace De_Tod_chill.Datos.Services;

public interface GenericService<T, ID> 
    where T : class
{
    T Create(T t);

    T Update(T t);

    T Get(ID id);
    
    ICollection<T> Get();

    T Delete(ID id);
}