using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Domain.Services
{
    public interface ITaskService
    {
        Task CreateTaskAsync(TaskEntity taskEntity);
    }
}
