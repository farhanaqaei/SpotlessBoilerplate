using Spotless.Domain.Common;

namespace Spotless.Domain.TodoItems;

public class TodoItem : BaseEntity
{
    public string Title { get; private set; }
    public string? Description { get; private set; }
    public TodoStatus Status { get; private set; }

    private TodoItem() { } // EF Core or serialization

    public TodoItem(string title, string? description = null)
    {
        Title = title ?? throw new ArgumentNullException(nameof(title));
        Description = description;
        Status = TodoStatus.NotStarted;

        AddDomainEvent(new TodoItemCreatedEvent(this));
    }

    public void MarkAsCompleted()
    {
        Status = TodoStatus.Completed;
        AddDomainEvent(new TodoItemCompletedEvent(this));
    }
}