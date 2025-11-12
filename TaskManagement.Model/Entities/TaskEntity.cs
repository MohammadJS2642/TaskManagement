namespace TaskManagement.Model.Entities;

public class TaskEntity : BaseEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public short State { get; set; }
}
