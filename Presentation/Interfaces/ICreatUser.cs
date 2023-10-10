using CleanArchitecture.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Presentation.Interfaces
{
    public interface ICreatUser
    {
        Task<IActionResult> CreateUserAsync([FromBody] UserDto userDto);
    }
}
