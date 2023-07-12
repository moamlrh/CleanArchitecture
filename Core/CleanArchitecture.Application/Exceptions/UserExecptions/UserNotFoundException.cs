
namespace CleanArchitecture.Application.Exceptions;


public class UserNotFoundException : Exception
{
    public UserNotFoundException(Guid Id) : base($"User with Id {Id} was not found in our database")
    {
    }
}