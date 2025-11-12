using TaskManagement.Model.Entities;

namespace TaskManagement.Application.Infrastructures;

public interface ITaskRepository
{
    Task AddAsync(TaskEntity taskEntity);
    Task<TaskEntity?> GetByIdAsync(int id);
    Task<IEnumerable<TaskEntity>> GetAllAsync();
    Task SaveChangesAsync();
}
