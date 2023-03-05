using Dishes.Domain.Entities;
using Dishes.Domain.Interfaces;
using Dishes.Infra.Context;
using Dishes.Infra.Repositories.Generic;
using Microsoft.EntityFrameworkCore;

namespace Dishes.Infra.Repositories;

public class DishRepository: GenericRepository<Dish>, IDishRepository
{
    public DishRepository(DishesDBContext _context): base(_context) { }

    public async Task<IEnumerable<Dish>> GetDishesByCategoryId(Guid id) => await _context.Dishes.Where(c => c.Category.Id == id).ToListAsync();
}