
namespace CleanArchitecture.Application.Repositories;

public interface IUnitOfWork
{
    IUserRepository UserRepository { get; }
    Task SaveAsync();
}