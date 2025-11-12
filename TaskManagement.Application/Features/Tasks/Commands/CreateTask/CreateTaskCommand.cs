using MediatR;
using TaskManagement.Application.DTOs;

namespace TaskManagement.Application.Features.Tasks.Commands.CreateTask;

public record CreateTaskCommand(string Title, string? Description, string Priority) : IRequest<TaskDto>;