using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Presentation.Interfaces
{
    public interface IDelete
    {
        Task<IActionResult> DeleteUserAsync(string username);
    }
}
