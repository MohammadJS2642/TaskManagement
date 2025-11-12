using Microsoft.EntityFrameworkCore;
using TaskManagement.Model.Entities;

namespace TaskManagement.Model.Context;

public class TaskManagementDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<TaskEntity> TaskEntities { get; set; }

    override protected void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<TaskEntity>(entity =>
         {
             //entity.Property(c => c.CreatedDate == DateTime.Now);
             entity.Property(c => c.ModifiedDate == DateTime.Now);

             entity.Property(e => e.Title)
                 .IsRequired()
                 .HasMaxLength(500);
         });
    }
}
