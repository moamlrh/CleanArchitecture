namespace CleanArchitecture.Application.Common;


public class BadRequestException : Exception
{
    public BadRequestException(string message) : base(message)
    {
    }
}