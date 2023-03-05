namespace Dishes.Domain.Interfaces.Generic;

public interface IGenericRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAll();
    Task<T> Get(Guid id);
    Task Add(T entity);
    void Delete(T entity);
    void Update(T entity);
}