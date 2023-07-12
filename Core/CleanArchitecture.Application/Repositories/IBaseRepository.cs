using System.Linq.Expressions;
using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Application.Common;

public interface IBaseRepository<T> where T : BaseEntity
{
    Task Create(T entity);
    void Delete(T entity);
    void Update(T entity);
    IQueryable<T> GetAll();
    IQueryable<T> GetByCondition(Expression<Func<T, bool>> condition);
}