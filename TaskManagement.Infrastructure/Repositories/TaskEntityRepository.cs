using Microsoft.EntityFrameworkCore;
using TaskManagement.Application.Infrastructures;
using TaskManagement.Domain.Entities;
using TaskManagement.Infrastructure.Persistence;

namespace TaskManagement.Infrastructure.Repositories;

public class TaskEntityRepository(TaskManagementDbContext context) : ITaskRepository
{
    public async Task AddAsync(TaskEntity taskEntity)
    {
        await context.TaskEntities.AddAsync(taskEntity);
    }

    public async Task<IEnumerable<TaskEntity>> GetAllAsync()
    {
        return await context.TaskEntities.ToListAsync();
    }

    public async Task<TaskEntity?> GetByIdAsync(int id)
    {
        return await context.TaskEntities.FindAsync(id);
    }

    public async Task SaveChangesAsync()
    {
        await context.SaveChangesAsync();
    }

}
