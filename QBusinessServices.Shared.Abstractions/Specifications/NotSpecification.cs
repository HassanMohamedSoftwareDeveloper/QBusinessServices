namespace QBusinessServices.Shared.Abstractions.Specifications;

public class NotSpecification<TEntity> : CompositeSpecification<TEntity>
{
    #region Fields :
    private readonly ISpecification<TEntity> _other;
    #endregion

    #region CTORS :
    public NotSpecification(ISpecification<TEntity> other)
    {
        this._other = other;
    }
    #endregion

    #region Methods :
    public override bool IsSatisfiedBy(TEntity entity) => !_other.IsSatisfiedBy(entity);
    #endregion
}
