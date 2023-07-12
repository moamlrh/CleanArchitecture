using CleanArchitecture.Application.Repositories;
using CleanArchitecture.Infrastrcutre.Persistence.Repositories;

namespace CleanArchitecture.Infrastructure.Persistence.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _dbContext;
    private readonly Lazy<IUserRepository> _userRepository;
    public UnitOfWork(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
        _userRepository = new(() => new UserRepository(dbContext));
    }
    public IUserRepository UserRepository => _userRepository.Value;
    public Task SaveAsync() => _dbContext.SaveChangesAsync();
}