using System.Linq.Expressions;

namespace Domain.Interfaces.Generic;

public interface IRepository<T>
{
    public Task<IEnumerable<T>> Get(Expression<Func<T, bool>> predicate);
    public void Add(T entity);
    public void Update(T entity);
    public void Delete(T entity);
}