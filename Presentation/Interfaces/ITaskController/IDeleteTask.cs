using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Presentation.Interfaces.ITaskController
{
    public interface IDeleteTask
    {
        Task<IActionResult> DeleteTaskAsync(string username, int id);
    }
}
