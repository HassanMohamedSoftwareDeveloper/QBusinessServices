using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using QBusinessServices.Shared.Abstractions.Domain;
using QBusinessServices.Shared.Abstractions.Specifications;

namespace QBusinessServices.Shared.Abstractions.Repositories;

public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class, IAggregateRoot
{
    #region Fields :
    protected readonly DbContext _context;
    protected readonly DbSet<TEntity> _entities;
    #endregion

    #region CTORS :
    public BaseRepository(DbContext context)
    {
        if (context is null) throw new ArgumentNullException(nameof(context));
        _context = context;
        _entities = _context.Set<TEntity>();
    }
    #endregion

    #region Methods :
    public Task<List<TEntity>> GetListAsync<TKey>(ISpecification<TEntity> specification, CancellationToken cancellationToken = default)
    {
        var query = _entities.AsQueryable();
        if (specification is not null) query = query.Where(x => specification.IsSatisfiedBy(x));
        return query.ToListAsync(cancellationToken);
    }
    public List<TEntity> GetList<TKey>(ISpecification<TEntity> specification)
    {
        var query = _entities.AsQueryable();
        if (specification is not null) query = query.Where(x => specification.IsSatisfiedBy(x));
        return query.ToList();
    }
    public Task<TEntity> GetAsync<TKey>(ISpecification<TEntity> specification, CancellationToken cancellationToken = default)
    {
        var query = _entities.AsQueryable();
        if (specification is not null) query = query.Where(x => specification.IsSatisfiedBy(x));
        return query.FirstOrDefaultAsync(cancellationToken);
    }
    public TEntity Get<TKey>(ISpecification<TEntity> specification)
    {
        var query = _entities.AsQueryable();
        if (specification is not null) query = query.Where(x => specification.IsSatisfiedBy(x));
        return query.FirstOrDefault();
    }
    public ValueTask<EntityEntry<TEntity>> CreateAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        return _entities.AddAsync(entity, cancellationToken);
    }
    public EntityEntry<TEntity> Create(TEntity entity)
    {
        return _entities.Add(entity);
    }
    public ValueTask<EntityEntry<TEntity>> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        if (cancellationToken != default) cancellationToken.ThrowIfCancellationRequested();
        return ValueTask.FromResult(_entities.Update(entity));
    }
    public EntityEntry<TEntity> Update(TEntity entity)
    {
        return _entities.Update(entity);
    }
    public ValueTask<EntityEntry<TEntity>> DeleteAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        if (cancellationToken != default) cancellationToken.ThrowIfCancellationRequested();
        return ValueTask.FromResult(_entities.Remove(entity));
    }
    public EntityEntry<TEntity> Delete(TEntity entity)
    {
        return _entities.Remove(entity);
    }
    #endregion
}
