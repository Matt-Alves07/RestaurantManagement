using Dishes.Domain.Validation;

namespace Dishes.Domain.Entities.Base
{
    public class BaseEntity
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Name { get; private set; }
        public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
        public string CreatedBy { get; private set; }
        public DateTime UpdateAt { get; private set; } = DateTime.UtcNow;
        public string UpdatedBy { get; private set; }

        public BaseEntity(Guid id, string name, DateTime createdAt, string createdBy)
        {
            Id = id;
            CreatedAt = createdAt;

            Validate(name, createdBy);
        }

        public BaseEntity(Guid id, string name, DateTime createdAt, string createdBy, DateTime updateAt, string updatedBy)
        {
            Id = id;
            CreatedAt = createdAt;
            UpdateAt = updateAt;

            Validate(name, createdBy, updatedBy);
        }

        private void Validate(string name, string createdBy)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Name can not be empty. Please, provide a valid name.");
            DomainExceptionValidation.When(name.Length < 3, "Name can not have less than 3 characters. Please, provide a valid name.");

            DomainExceptionValidation.When(string.IsNullOrEmpty(createdBy), "Creator's name can not be empty. Please, provide a valid name.");
            DomainExceptionValidation.When(createdBy.Length < 3, "Creator's name can not have less than 3 characters. Please, provide a valid name.");

            Name = name;
            CreatedBy = createdBy;
        }

        private void Validate(string name, string createdBy, string updatedBy)
        {
            Validate(name, createdBy);

            DomainExceptionValidation.When(string.IsNullOrEmpty(createdBy), "Update's user name can not be empty. Please, provide a valid name.");
            DomainExceptionValidation.When(createdBy.Length < 3, "Update's user name can not have less than 3 characters. Please, provide a valid name.");

            Name = name;
            CreatedBy = createdBy;
            UpdatedBy = updatedBy;
        }
    }
}