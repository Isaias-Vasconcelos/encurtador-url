using System.Linq.Expressions;
using Data.Context;
using Domain.Interfaces.Generic;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories.Generic;

public class Repository<T>(ApplicationContext context) : IRepository<T>
    where T : class
{
    private readonly ApplicationContext _context = context;
    private readonly DbSet<T> _dbSet = context.Set<T>();

    public async Task<IEnumerable<T>> Get(Expression<Func<T, bool>> predicate)
    {
        var entities = await _dbSet
            .Where(predicate)
            .ToListAsync();
        return entities;
    }

    public void Add(T entity)
    {
        _dbSet.Add(entity);
    }

    public void Update(T entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
    }

    public void Delete(T entity)
    {
        _dbSet.Remove(entity);
    }
}