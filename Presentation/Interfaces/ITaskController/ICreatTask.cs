using CleanArchitecture.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Presentation.Interfaces.ITaskController
{
    public interface ICreatTask
    {
        Task<IActionResult> CreateUserAsync(string userName,[FromBody] TaskDto taskDto);
    }
}
