namespace TaskManagement.Model.Entities;

public class BaseEntity
{
    public int Id { get; set; }
    public int CreatorUserId { get; set; }
    public DateTime CreatedDate { get; set; }
    public int ModifierUserId { get; set; }
    public DateTime ModifiedDate { get; set; }
}
