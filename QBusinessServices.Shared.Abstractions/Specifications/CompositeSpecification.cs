namespace QBusinessServices.Shared.Abstractions.Specifications;

public abstract class CompositeSpecification<TEntity> : ISpecification<TEntity>
{
    public abstract bool IsSatisfiedBy(TEntity entity);
    public ISpecification<TEntity> And(ISpecification<TEntity> other) => new AndSpecification<TEntity>(this, other);
    public ISpecification<TEntity> AndNot(ISpecification<TEntity> other) => new AndNotSpecification<TEntity>(this, other);
    public ISpecification<TEntity> Or(ISpecification<TEntity> other) => new OrSpecification<TEntity>(this, other);
    public ISpecification<TEntity> OrNot(ISpecification<TEntity> other) => new OrNotSpecification<TEntity>(this, other);
    public ISpecification<TEntity> Not() => new NotSpecification<TEntity>(this);
}
