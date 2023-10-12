using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Domain.Services
{
    public interface IGetUserService
    {
        Task<UserEntity> GetUserAsync(string userName);
    }
}
