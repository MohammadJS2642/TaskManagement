namespace TaskManagement.Application.DTOs;

public record TaskDto(int Id, string Title, string? Description, string Priority);
