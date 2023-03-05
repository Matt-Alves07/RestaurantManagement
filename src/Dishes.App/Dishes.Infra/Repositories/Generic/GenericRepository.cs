using Dishes.Domain.Interfaces.Generic;
using Dishes.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace Dishes.Infra.Repositories.Generic;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    protected readonly DishesDBContext _context;
    public GenericRepository(DishesDBContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<T>> GetAll() => await _context.Set<T>().ToListAsync();
    public async Task<T> Get(Guid id) => await _context.Set<T>().FindAsync(id);
    public async Task Add(T entity) => await _context.Set<T>().AddAsync(entity);
    public void Delete(T entity) => _context.Set<T>().Remove(entity);
    public void Update(T entity) => _context.Set<T>().Update(entity);
}