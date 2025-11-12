using TaskManagement.Domain.Common;
using TaskManagement.Domain.Events;
using TaskManagement.Domain.ValueObjects;

namespace TaskManagement.Domain.Entities;

public class TaskEntity : BaseEntity
{
    public string Title { get; private set; }
    public string? Description { get; private set; }
    public short State { get; private set; }
    public TaskPriority Priority { get; set; }

    private TaskEntity() { }

    public TaskEntity(string title, string? description, TaskPriority priority)
    {
        Title = title;
        Description = description;
        //State = state.HasValue == true ? 1 : state;
        State = 1;
    }

    public void IsCompleted()
    {
        if (State == 2)
            throw new InvalidCastException("Task is already completed.");
        State = 2;

        AddDomainEvent(new TaskCompletedEvent(Id));
    }
}
