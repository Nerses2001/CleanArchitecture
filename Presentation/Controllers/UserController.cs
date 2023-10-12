using CleanArchitecture.Domain.Models;
using CleanArchitecture.Domain.Services;
using CleanArchitecture.Presentation.Interfaces.IUserConttroller;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Presentation.Controllers
{
    [ApiController]
    [Route("api/taskmanagment/[controller]")]
    public class UserController : ControllerBase, ICreatUser, IPutUser, IDeleteUser
    {
        private readonly IUserService _userServices;

        public UserController(IUserService userServices)
        {
            this._userServices = userServices ?? throw new(nameof(_userServices));
        }

        [HttpPost("creatuser")]
        public async Task<IActionResult> CreateUserAsync([FromBody] UserDto userDto)
        {
        
            if (userDto != null)
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);
                
                UserEntity user = new
                    (
                       userDto.UserName,
                       userDto.Name,
                       userDto.LName,
                       userDto.Email,
                       userDto.PNumber
                    );
                await _userServices.CreateUserAsync(user);
                return Ok("User created successfully");
            }
         

            return BadRequest("Invalid user data.");
        }

        [HttpPut("updateuser/{username}")]
        public async Task<IActionResult> PutUserAsync(string username, [FromBody] UserDto userDto)
        {
            if (userDto != null)
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);
                
                UserEntity updatedUser = new
                    (
                       userDto.UserName,
                       userDto.Name,
                       userDto.LName,
                       userDto.Email,
                       userDto.PNumber
                    );
                await _userServices.PutUserAsync(username, updatedUser);
                return Ok("User updated successfully");
            }
            return BadRequest("Invalid user data.");
        }

        [HttpDelete("deleteuser/{username}")]
        public async Task<IActionResult> DeleteUserAsync(string username)
        {
            if (!string.IsNullOrEmpty(username))
            {
                await _userServices.DeleteUserAsync(username);
                return Ok("User deleted successfully");
            }

            return BadRequest("Invalid username.");
        }


    }
}