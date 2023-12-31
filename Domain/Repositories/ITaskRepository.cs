﻿using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Domain.Repositories
{
    public interface ITaskRepository
    {
        Task CreatAsync(TaskEntity tasks);
        Task<IEnumerable<TaskEntity>> GetAsync(int userId);
        Task UpdateAsync(TaskEntity taskEntity);
        Task DeleteAsync(TaskEntity taskEntity);
    }
}
