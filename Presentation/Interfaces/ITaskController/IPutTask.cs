using CleanArchitecture.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Presentation.Interfaces.ITaskController
{
    public interface IPutTask
    {
        Task<IActionResult> PutUserTaskAsync(string username, int id, [FromBody] TaskDto taskDto);
    }
}
