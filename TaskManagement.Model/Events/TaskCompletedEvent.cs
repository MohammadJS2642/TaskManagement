namespace TaskManagement.Domain.Events;

public class TaskCompletedEvent(int taskId)
{
    public int TaskId { get; } = taskId;
}
