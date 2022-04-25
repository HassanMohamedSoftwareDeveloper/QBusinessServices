namespace QBusinessServices.Shared.Abstractions.Domain;

public class BaseEntity<TKey> : IEntity
{
    public TKey Id { get; set; }
}
