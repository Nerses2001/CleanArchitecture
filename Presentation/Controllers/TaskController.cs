using CleanArchitecture.Domain.Models;
using CleanArchitecture.Domain.Services;
using CleanArchitecture.Presentation.Interfaces.ITaskController;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Presentation.Controllers
{
    [Route("api/taskmanagment/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase, ICreatTask
    {
        private readonly IGetUserService _getUser;
        private readonly ITaskService _taskService;
        public TaskController(ITaskService taskService,IGetUserService getUser)
        {
            this._taskService = taskService;
            this._getUser = getUser;
        }

        [HttpPost("creattask/{username}")]
        public async Task<IActionResult> CreateUserAsync(string username, [FromBody] TaskDto taskDto)
        {
            if (taskDto == null)
                return BadRequest("Invalid task data.");
            Console.WriteLine(new string('_', 50));
            Console.WriteLine(username);

            Console.WriteLine(new string('_', 50));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);



         
            var user = await _getUser.GetUserAsync(username);

            Console.WriteLine(new string('_', 70));
            if (user == null)
                return NotFound("User not found.");


            Console.WriteLine(new string('_', 80));
            TaskEntity task = new(taskDto.Name, taskDto.Description, taskDto.DueDate, taskDto.Status, user.Id)
            {
                User = user
            };

            Console.WriteLine(new string('_', 90));

            await _taskService.CreateTaskAsync(task);

            Console.WriteLine(new string('_', 100));
            return Ok("Task created successfully");

        }



    }
}
