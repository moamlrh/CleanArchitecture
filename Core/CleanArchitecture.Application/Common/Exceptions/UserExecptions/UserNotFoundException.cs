
namespace CleanArchitecture.Application.Common;


public class UserNotFoundException : Exception
{
    public UserNotFoundException(Guid Id) : base($"User with Id {Id} was not found in our database")
    {
    }
}