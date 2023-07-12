using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Repositories;

public interface IUserRepository
{
    Task<User> GetUserById(Guid Id);
    Task CreateUser(User user);
}