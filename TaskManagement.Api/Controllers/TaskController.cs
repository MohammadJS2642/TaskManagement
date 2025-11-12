using Microsoft.AspNetCore.Mvc;
using TaskManagement.Application.UseCases.TaskEntityCase;
using TaskManagement.Model.Entities;

namespace TaskManagement.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController(CreateTaskHandler createTask) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateTask([FromBody] TaskEntity taskEntity)
        {
            var result = await createTask.HandleAsync(taskEntity);
            return CreatedAtAction(nameof(CreateTask), new { id = result.Id }, result);
        }
    }
}
