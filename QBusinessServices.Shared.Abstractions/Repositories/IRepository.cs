using Microsoft.EntityFrameworkCore.ChangeTracking;
using QBusinessServices.Shared.Abstractions.Domain;
using QBusinessServices.Shared.Abstractions.Specifications;

namespace QBusinessServices.Shared.Abstractions.Repositories;

public interface IRepository<TEntity> where TEntity : class, IAggregateRoot
{
    Task<List<TEntity>> GetListAsync<TKey>(ISpecification<TEntity> specification, CancellationToken cancellationToken = default);
    List<TEntity> GetList<TKey>(ISpecification<TEntity> specification);
    Task<TEntity> GetAsync<TKey>(ISpecification<TEntity> specification, CancellationToken cancellationToken = default);
    TEntity Get<TKey>(ISpecification<TEntity> specification);
    ValueTask<EntityEntry<TEntity>> CreateAsync(TEntity entity, CancellationToken cancellationToken = default);
    EntityEntry<TEntity> Create(TEntity entity);
    ValueTask<EntityEntry<TEntity>> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default);
    EntityEntry<TEntity> Update(TEntity entity);
    ValueTask<EntityEntry<TEntity>> DeleteAsync(TEntity entity, CancellationToken cancellationToken = default);
    EntityEntry<TEntity> Delete(TEntity entity);
}
