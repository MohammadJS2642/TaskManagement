using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TaskManagement.Application.Infrastructures;
using TaskManagement.Infrastructure.Persistence;
using TaskManagement.Infrastructure.Repositories;

namespace TaskManagement.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
    {
        // Register infrastructure services here
        services.AddDbContext<TaskManagementDbContext>(opt => opt.UseSqlite());

        services.AddScoped<ITaskRepository, TaskEntityRepository>();
        return services;
    }
}
