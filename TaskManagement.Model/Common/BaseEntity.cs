namespace TaskManagement.Domain.Common;

public class BaseEntity
{
    public int Id { get; protected set; }
    public int CreatorUserId { get; set; }
    public DateTime CreatedDate { get; set; }
    public int ModifierUserId { get; set; }
    public DateTime ModifiedDate { get; set; }

    private readonly List<object> _domainEvenet = new();
    public IReadOnlyCollection<object> DomainEvents => _domainEvenet.AsReadOnly();

    protected void AddDomainEvent(object domainEvent) => _domainEvenet.Add(domainEvent);
    public void ClearDomainEvents() => _domainEvenet.Clear();
}
