using Dishes.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dishes.Infra.Context;

public class DishesDBContext: DbContext
{
    public DishesDBContext(DbContextOptions<DishesDBContext> options) : base(options) { }

    public DbSet<Dish> Dishes { get; set; }
    public DbSet<Category> Category { get; set; }
}