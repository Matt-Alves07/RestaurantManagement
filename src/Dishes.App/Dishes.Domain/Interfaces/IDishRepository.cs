using Dishes.Domain.Entities;
using Dishes.Domain.Interfaces.Generic;

namespace Dishes.Domain.Interfaces;

public interface IDishRepository: IGenericRepository<Dish>
{
    Task<IEnumerable<Dish>> GetDishesByCategoryId(Guid id);
}