using System.Linq.Expressions;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Application.Repositories;
using CleanArchitecture.Infrastructure.Persistence;
using CleanArchitecture.Infrastructure.Persistence.Repositories;

namespace CleanArchitecture.Infrastrcutre.Persistence.Repositories;


public class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
    public Task<User> GetUserById(Guid Id)
    {
        throw new NotImplementedException();
    }
    public async Task CreateUser(User user) => await Create(user);
}