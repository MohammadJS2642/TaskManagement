namespace TaskManagement.Domain.ValueObjects;

public record TaskPriority(string Name, int Level)
{
    public static readonly TaskPriority Low = new("Low", 1);
    public static readonly TaskPriority Medium = new("Medium", 2);
    public static readonly TaskPriority High = new("High", 3);
}
