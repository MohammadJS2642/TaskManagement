using Microsoft.EntityFrameworkCore;
using TaskManagement.Model.Entities;

namespace TaskManagement.Infrastructure.Persistence;

public class TaskManagementDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<TaskEntity> TaskEntities { get; set; }
}
