using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Domain.Services
{
    public interface IUserServices
    {
        Task CreateUserAsync(UserEntity user);
        Task PutUserAsync(string userName, UserEntity updatedUser);
        Task DeleteUserAsync(string userName);
    }
}
