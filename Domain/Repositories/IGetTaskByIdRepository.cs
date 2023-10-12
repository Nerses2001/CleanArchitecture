using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Domain.Repositories
{
    public interface IGetTaskByIdRepository
    {
        Task<TaskEntity> GetTaskByIdAsync(int taskId, int userId);

    }
}
