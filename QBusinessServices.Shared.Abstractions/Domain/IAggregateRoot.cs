namespace QBusinessServices.Shared.Abstractions.Domain;

public interface IAggregateRoot
{
    public IEnumerable<IDomainEvent> Events { get; }

    void AddEvent(IDomainEvent @event);
    void RemoveEvent(IDomainEvent @event);
    void ClearEvents();
}
