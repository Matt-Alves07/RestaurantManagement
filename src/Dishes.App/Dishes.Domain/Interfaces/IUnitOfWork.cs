namespace Dishes.Domain.Interfaces;

public interface IUnitOfWork:IDisposable
{
    IDishRepository Dishes { get; }
    ICategoryRepository Categories { get; }
    int Commit();
}