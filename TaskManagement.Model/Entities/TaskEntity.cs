namespace TaskManagement.Model.Entities;

public class TaskEntity : BaseEntity
{
    public string Title { get; private set; }
    public string Description { get; private set; }
    public short State { get; private set; }

    public TaskEntity(string title, string? description, short? state)
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
    }
}
