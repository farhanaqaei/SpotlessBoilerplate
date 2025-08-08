namespace Spotless.Domain.Common;

public interface IHasDomainEvent
{
    IReadOnlyCollection<DomainEvent> DomainEvents { get; }
    void ClearDomainEvents();
}