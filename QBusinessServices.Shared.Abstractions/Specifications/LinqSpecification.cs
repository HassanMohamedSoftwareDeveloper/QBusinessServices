using System.Linq.Expressions;

namespace QBusinessServices.Shared.Abstractions.Specifications;

public abstract class LinqSpecification<TEntity> : CompositeSpecification<TEntity>
{
    public abstract Expression<Func<TEntity, bool>> AsExpression();
    public override bool IsSatisfiedBy(TEntity entity) => AsExpression().Compile()(entity);
}
