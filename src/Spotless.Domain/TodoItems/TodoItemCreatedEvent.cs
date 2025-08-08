using Spotless.Domain.Common;

namespace Spotless.Domain.TodoItems;

public class TodoItemCreatedEvent : DomainEvent
{
    public TodoItem Item { get; }

    public TodoItemCreatedEvent(TodoItem item)
    {
        Item = item;
    }
}