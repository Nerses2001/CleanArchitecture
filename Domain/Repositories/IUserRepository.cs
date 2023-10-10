using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Domain.Repositories
{
    public interface IUserRepository
    {
        Task CreatAsync(UserEntity user);
        Task PutAsync(string userName, UserEntity updatedUser);
    }
}
