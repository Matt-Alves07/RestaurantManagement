using Dishes.Domain.Entities.Base;
using Dishes.Domain.Validation;

namespace Dishes.Domain.Entities;

public class Dish : BaseEntity
{
    public bool IsAvailable { get; private set; } = false;
    public Decimal Price { get; private set; }

    public Dish(Guid id, string name, DateTime createdAt, string createdBy, bool isAvailable, Decimal price): base(id, name, createdAt, createdBy)
    {
        IsAvailable = isAvailable;

        validate(price);
    }

    public Dish(Guid id, string name, DateTime createdAt, string createdBy, DateTime updatedAt,  string updatedBy, bool isAvailable, Decimal price): base(id, name, createdAt, createdBy, updatedAt, updatedBy)
    {
        IsAvailable = isAvailable;

        validate(price);
    }

    private void validate(Decimal price)
    {
        DomainExceptionValidation.When(string.IsNullOrEmpty(price.ToString()), "Price can not be null. Please, provide a valid price.");
        DomainExceptionValidation.When(Decimal.IsNegative(price), "Price can not be smaller than 0(zero). Please, provide a valid price.");
        DomainExceptionValidation.When(Decimal.Zero == price, "Price can not be 0(zero). Please, provide a valid price.");

        Price = price;
    }
}