using MediatR;

namespace CleanArchitecture.Application.Features
{
    public record CreateUserRequest(string Name, string Email, string Password) : IRequest;
}