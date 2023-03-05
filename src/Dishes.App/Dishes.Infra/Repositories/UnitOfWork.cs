using Dishes.Domain.Interfaces;
using Dishes.Infra.Context;

namespace Dishes.Infra.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly DishesDBContext _context;
    public IDishRepository Dishes { get; }
    public ICategoryRepository Categories { get; }

    public UnitOfWork(DishesDBContext context, IDishRepository dishes, ICategoryRepository categories)
    {
        _context = context;
        Dishes = dishes;
        Categories = categories;
    }

    public int Commit() => _context.SaveChanges();

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
            _context.Dispose();
    }
}