namespace QBusinessServices.Shared.Abstractions.Specifications;

public interface ISpecification<TEntity>
{
    bool IsSatisfiedBy(TEntity entity);
    ISpecification<TEntity> And(ISpecification<TEntity> other);
    ISpecification<TEntity> AndNot(ISpecification<TEntity> other);
    ISpecification<TEntity> Or(ISpecification<TEntity> other);
    ISpecification<TEntity> OrNot(ISpecification<TEntity> other);
    ISpecification<TEntity> Not();
}
