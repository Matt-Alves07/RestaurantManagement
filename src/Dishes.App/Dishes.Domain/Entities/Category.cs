using Dishes.Domain.Entities.Base;
using Dishes.Domain.Validation;
using System.Net.Http.Headers;

namespace Dishes.Domain.Entities;

public class Category: BaseEntity
{
    public string Description { get; private set; }
    public IEnumerable<Dish> Dishes { get; set; }

    public Category(Guid id, string name, string description, DateTime createdAt, string createdBy) : base(id, name, createdAt, createdBy)
    {
        Validate(description);
    }

    public Category(Guid id, string name, string description, DateTime createdAt, string createdBy, DateTime updatedAt, string updatedBy): base(id, name, createdAt, createdBy, updatedAt, updatedBy)
    {
        Validate(description);
    }

    private void Validate(string description)
    {
        DomainExceptionValidation.When(string.IsNullOrEmpty(description), "Description can not be null. Please, provide a valid description.");
        DomainExceptionValidation.When(description.Length < 10, "Description can not have less than 10 characters. Please, provide a valid description.");

        Description = description;
    }
}
