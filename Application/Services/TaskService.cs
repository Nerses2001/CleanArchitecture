using CleanArchitecture.Domain.Models;
using CleanArchitecture.Domain.Repositories;
using CleanArchitecture.Domain.Services;

namespace CleanArchitecture.Application.Services
{
    public class TaskService : ITaskService, IGetTaskByIdService
    {
        private readonly ITaskRepository _taskRepository;
        private readonly IGetTaskByIdRepository _taskByIdRepository;

        public TaskService(ITaskRepository taskRepository, IGetTaskByIdRepository getTaskByIdRepository)
        {
            this._taskRepository = taskRepository;
            this._taskByIdRepository = getTaskByIdRepository;
        }
        public async Task CreateTaskAsync(TaskEntity taskEntity)
        {
            await _taskRepository.CreatAsync(taskEntity);

        }

        public async Task DeleteTaskAsync(TaskEntity taskEntity)
        {
            await _taskRepository.DeleteAsync(taskEntity);
        }

        public async Task<IEnumerable<TaskDto>> GetTaskAsync(int userId)
        {
            var tasks =  await _taskRepository.GetAsync(userId);
            return tasks.Select(taskEntity => TaskDto.FromTaskEntity(taskEntity));
        }

        public async Task<TaskEntity> GetTaskByIdAsync(int taskId, int userId)
        {
            return await _taskByIdRepository.GetTaskByIdAsync(taskId, userId);
        }

        public async Task UpdateTaskAsync(TaskEntity task)
        {
            await _taskRepository.UpdateAsync(task);
        }
    }
}
