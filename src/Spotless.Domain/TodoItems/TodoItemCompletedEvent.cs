using Spotless.Domain.Common;

namespace Spotless.Domain.TodoItems;

public class TodoItemCompletedEvent : DomainEvent
{
    public TodoItem Item { get; }

    public TodoItemCompletedEvent(TodoItem item)
    {
        Item = item;
    }
}