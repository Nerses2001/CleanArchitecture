using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Domain.Services
{
    public interface IUserService
    {
        Task CreateUserAsync(UserEntity user);
        Task PutUserAsync(string userName, UserEntity updatedUser);
        Task DeleteUserAsync(string userName);

        Task<UserEntity> GetUserAsync(string userName);
    }
}
