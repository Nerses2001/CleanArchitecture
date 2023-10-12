using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Domain.Repositories
{
    public interface IGetUserRepository
    {
        public Task<UserEntity> GetAsync(string userName);
    }
}
