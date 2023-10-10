using CleanArchitecture.Domain.Models;
using CleanArchitecture.Domain.Repositories;
using CleanArchitecture.Domain.Services;

namespace CleanArchitecture.Application.Services
{
    public class UserService : IUserServices
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }
        public async Task CreateUserAsync(UserEntity user)
        {
            if(user == null) throw new(nameof(user));
            await _userRepository.CreatAsync(user);
        }

        public async Task PutUserAsync(string userName, UserEntity updatedUser)
        {
        Console.WriteLine(userName + " " + updatedUser.UserName);
            if (updatedUser == null) throw new (nameof(updatedUser));
            await _userRepository.PutAsync(userName, updatedUser);
        }
    }
}
