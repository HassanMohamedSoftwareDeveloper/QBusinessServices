namespace QBusinessServices.Shared.Abstractions.Domain;

public abstract class AggregateRoot<TKey> : IAggregateRoot
{
    public TKey Id { get; private set; }

    public IEnumerable<IDomainEvent> Events => _events;
    private readonly List<IDomainEvent> _events = new();

    public void AddEvent(IDomainEvent @event) => _events.Add(@event);
    public void RemoveEvent(IDomainEvent @event) => _events.Remove(@event);
    public void ClearEvents() => _events.Clear();
}