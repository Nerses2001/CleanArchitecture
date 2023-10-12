using CleanArchitecture.Domain.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace CleanArchitecture.Domain.Services
{
    public interface IGetTaskByIdService
    {
        Task<TaskEntity> GetTaskByIdAsync(int  taskId, int userId);
    }
}
