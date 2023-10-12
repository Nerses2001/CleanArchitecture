using CleanArchitecture.Domain.Models;
using CleanArchitecture.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Data.Repositories
{
    public class TaskRepository : ITaskRepository
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
    }
}
