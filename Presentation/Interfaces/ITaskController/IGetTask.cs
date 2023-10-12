using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Presentation.Interfaces.ITaskController
{
    public interface IGetTask
    {
        Task<IActionResult> GetUserTasksAsync(string username);

    }
}
