using CleanArchitecture.Domain.Models;
using CleanArchitecture.Domain.Services;
using CleanArchitecture.Presentation.Interfaces.ITaskController;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Presentation.Controllers
{
    [Route("api/taskmanagment/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase, ICreatTask, IGetTask, IPutTask
    {
        private readonly IGetUserService _getUser;
        private readonly ITaskService _taskService;
        private readonly IGetTaskByIdService _taskByIdService;
        public TaskController(ITaskService taskService,IGetUserService getUser, IGetTaskByIdService taskByIdService)
        {
            this._taskService = taskService;
            this._getUser = getUser;
            this._taskByIdService = taskByIdService;

        }

        [HttpPost("creattask/{username}")]
        public async Task<IActionResult> CreateUserAsync(string username, [FromBody] TaskDto taskDto)
        {
            if (taskDto == null)
                return BadRequest("Invalid task data.");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            var user = await _getUser.GetUserAsync(username);

            
            if (user == null)
                return NotFound("User not found.");

            TaskEntity task = new(taskDto.Name, taskDto.Description, taskDto.DueDate, taskDto.Status, user.Id)
            {
                User = user
            };

            await _taskService.CreateTaskAsync(task);

            return Ok("Task created successfully");

        }


        [HttpGet("getusertasks/{username}")]
        public async Task<IActionResult> GetUserTasksAsync(string username)
        {
            var user = await _getUser.GetUserAsync(username);
            
            if (user == null) return BadRequest("User Not Found");

            var userTasks = await _taskService.GetTaskAsync(user.Id);
            return Ok(userTasks);
        }

        [HttpPut("putusertask{username}/{id}")]
        public async Task<IActionResult> PutUserTaskAsync(string username, int id, [FromBody] TaskDto taskDto)
        {
            if(taskDto == null) return BadRequest("Invalid task data.");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var user = await _getUser.GetUserAsync(username);
            if (user == null)
                return NotFound("User not found.");
            
            var taskToUpdate = await _taskByIdService.GetTaskByIdAsync(id);
            
            if (taskToUpdate == null)
                return NotFound("Task not found.");

            taskToUpdate.Name = taskDto.Name;
            taskToUpdate.Description = taskDto.Description;
            taskToUpdate.DueDate = taskDto.DueDate;
            taskToUpdate.Status = taskDto.Status;
            await _taskService.UpdateTaskAsync(taskToUpdate);

            return Ok("Task updated successfully");

        }


    }
}
