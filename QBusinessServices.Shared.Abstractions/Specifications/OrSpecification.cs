namespace QBusinessServices.Shared.Abstractions.Specifications;

public class OrSpecification<TEntity> : CompositeSpecification<TEntity>
{
    #region Fields :
    private readonly ISpecification<TEntity> _left;
    private readonly ISpecification<TEntity> _right;
    #endregion

    #region CTORS :
    public OrSpecification(ISpecification<TEntity> left, ISpecification<TEntity> right)
    {
        this._left = left;
        this._right = right;
    }
    #endregion

    #region Methods :
    public override bool IsSatisfiedBy(TEntity entity) => _left.IsSatisfiedBy(entity) || _right.IsSatisfiedBy(entity);
    #endregion
}
