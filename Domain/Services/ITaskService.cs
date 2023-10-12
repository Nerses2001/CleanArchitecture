using CleanArchitecture.Domain.Models;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Services
{
    public interface ITaskService
    {
        Task CreateTaskAsync(TaskEntity taskEntity);
        Task<IEnumerable<TaskDto>> GetTaskAsync(int userId);
        Task UpdateTaskAsync(TaskEntity task);

        Task DeleteTaskAsync(TaskEntity taskEntity);
    }
}
