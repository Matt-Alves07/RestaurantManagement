namespace Dishes.Domain.Validation;

public class DomainExceptionValidation: Exception
{
    public DomainExceptionValidation(string message): base(message) { }

    public static void When(bool isValid, string message)
    {
        if (isValid)
            throw new DomainExceptionValidation(message);
    }
}