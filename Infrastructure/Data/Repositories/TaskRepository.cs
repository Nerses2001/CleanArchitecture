using CleanArchitecture.Domain.Models;
using CleanArchitecture.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Data.Repositories
{
    public class TaskRepository : ITaskRepository, IGetTaskByIdRepository
    {
        private readonly DbAppContext _dbAppContext;

        public TaskRepository(DbAppContext dbAppContext)
        {
            this._dbAppContext = dbAppContext;
        }

        public async Task CreatAsync(TaskEntity task)
        {
            
            if (task == null) throw new ArgumentNullException(nameof(task));
            
            await _dbAppContext.Tasks.AddAsync(task);
            await _dbAppContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(TaskEntity taskEntity)
        {
            if(taskEntity == null) throw new (nameof (taskEntity));
            _dbAppContext.Tasks.Remove(taskEntity);
            await _dbAppContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<TaskEntity>> GetAsync(int userId)
        {
            var tasks = await _dbAppContext.Tasks.Where(t => t.UserId == userId).ToListAsync();
            return tasks;
        }

        public async Task<TaskEntity> GetTaskByIdAsync(int taskId, int userId)
        {
            var task = await _dbAppContext.Tasks.SingleOrDefaultAsync(t => t.Id == taskId && t.UserId == userId);
            if (task == null) throw new(nameof(task));
            return task;
        }

        public async Task UpdateAsync(TaskEntity taskEntity)
        {

            if(taskEntity == null) throw new ArgumentNullException(nameof (taskEntity));

            _dbAppContext.Tasks.Update(taskEntity);
            await _dbAppContext.SaveChangesAsync();

        }
    }
}
