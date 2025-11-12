using TaskManagement.Application.Infrastructures;
using TaskManagement.Model.Entities;

namespace TaskManagement.Application.UseCases.TaskEntityCase;

public class CreateTaskHandler(ITaskRepository taskRepository)
{
    private readonly ITaskRepository _taskRepository = taskRepository;

    public async Task<TaskEntity> HandleAsync(TaskEntity taskEntity)
    {
        await _taskRepository.AddAsync(taskEntity);
        await _taskRepository.SaveChangesAsync();
        return taskEntity;
    }

}
