
using System.Linq.Expressions;
using CleanArchitecture.Application.Common;
using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Infrastructure.Persistence.Repositories;

public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
{
    private readonly ApplicationDbContext dbContext;

    public BaseRepository(ApplicationDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    public async Task Create(T entity) => await dbContext.Set<T>().AddAsync(entity);
    public void Delete(T entity) => dbContext.Set<T>().Remove(entity);
    public void Update(T entity) => dbContext.Set<T>().Update(entity);
    public IQueryable<T> GetAll() => dbContext.Set<T>();
    public IQueryable<T> GetByCondition(Expression<Func<T, bool>> condition) => dbContext.Set<T>().Where(condition);
}
