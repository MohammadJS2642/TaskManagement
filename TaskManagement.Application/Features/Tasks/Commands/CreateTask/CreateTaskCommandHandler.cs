using MediatR;
using TaskManagement.Application.DTOs;
using TaskManagement.Application.Infrastructures;
using TaskManagement.Domain.Entities;
using TaskManagement.Domain.ValueObjects;

namespace TaskManagement.Application.Features.Tasks.Commands.CreateTask;

public class CreateTaskCommandHandler(ITaskRepository taskRepository) : IRequestHandler<CreateTaskCommand, TaskDto>
{
    public async Task<TaskDto> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
    {
        var priority = request.Priority.ToLower() switch
        {
            "low" => TaskPriority.Low,
            "medium" => TaskPriority.Medium,
            "high" => TaskPriority.High,
            _ => TaskPriority.Medium
        };

        var task = new TaskEntity(request.Title, request.Description, priority);
        await taskRepository.AddAsync(task);
        await taskRepository.SaveChangesAsync();
        return new TaskDto
        {
            Id= task.Id,
            Title = task.Title,
            Description = task.Description,
            Priority = task.Priority.Name
        };
    }
}
