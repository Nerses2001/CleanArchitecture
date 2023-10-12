using CleanArchitecture.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Presentation.Interfaces.IUserConttroller
{
    public interface IPutUser
    {
        Task<IActionResult> PutUserAsync(string username, [FromBody] UserDto userDto);
    }
}
