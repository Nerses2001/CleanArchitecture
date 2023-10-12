using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Presentation.Interfaces.IUserConttroller
{
    public interface IDeleteUser
    {
        Task<IActionResult> DeleteUserAsync(string username);
    }
}
