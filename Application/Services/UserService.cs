using CleanArchitecture.Domain.Models;
using CleanArchitecture.Domain.Repositories;
using CleanArchitecture.Domain.Services;

namespace CleanArchitecture.Application.Services
{
    public class UserService : IUserService, IGetUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IGetUserRepository _getUser;
        public UserService(IUserRepository userRepository, IGetUserRepository getUser)
        {
            this._userRepository = userRepository;
            this._getUser = getUser;
        }
        public async Task CreateUserAsync(UserEntity user)
        {
            if(user == null) throw new(nameof(user));
            await _userRepository.CreatAsync(user);
        }

        public async Task PutUserAsync(string userName, UserEntity updatedUser)
        {
            if (updatedUser == null) throw new (nameof(updatedUser));
            await _userRepository.PutAsync(userName, updatedUser);
        }

        public async Task DeleteUserAsync(string userName)
        {
            await _userRepository.DeleteAsync(userName);
        }

        public async Task<UserEntity> GetUserAsync(string userName)
        {
            return await _getUser.GetAsync(userName);
        }

    }
}
