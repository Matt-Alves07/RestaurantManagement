using Dishes.Domain.Entities;
using Dishes.Domain.Interfaces;
using Dishes.Infra.Context;
using Dishes.Infra.Repositories.Generic;

namespace Dishes.Infra.Repositories;

public class CategoryRepository: GenericRepository<Category>, ICategoryRepository
{
    public CategoryRepository(DishesDBContext _context) : base(_context) { }  
}