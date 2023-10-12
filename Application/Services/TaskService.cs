﻿using CleanArchitecture.Domain.Models;
using CleanArchitecture.Domain.Repositories;
using CleanArchitecture.Domain.Services;

namespace CleanArchitecture.Application.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            this._taskRepository = taskRepository;
        }
        public async Task CreateTaskAsync(TaskEntity taskEntity)
        {
            await _taskRepository.CreatAsync(taskEntity);

        }

        public async Task<IEnumerable<TaskDto>> GetTaskAsync(int userId)
        {
            var tasks =  await _taskRepository.GetAsync(userId);
            return tasks.Select(taskEntity => TaskDto.FromTaskEntity(taskEntity));
        }
    }
}
