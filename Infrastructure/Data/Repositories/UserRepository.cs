using CleanArchitecture.Domain.Models;
using CleanArchitecture.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Data.Repositories
{
    public class UserRepository : IUserRepository, IGetUserRepository
    {
        private readonly DbAppContext _dbContext;

        public UserRepository(DbAppContext dbAppContext)
        {
            this._dbContext = dbAppContext;
        }

        public async Task CreatAsync(UserEntity user)
        {
            if (user == null)
                throw new(nameof(user));
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
        }


        public async Task PutAsync(string userName, UserEntity updatedUser)
        {
            if (string.IsNullOrWhiteSpace(userName))
                throw new (nameof(userName));

            if (updatedUser != null)
            {
                var existingUser = await _dbContext.Users.SingleOrDefaultAsync(u => u.UserName == userName) ?? throw new InvalidOperationException("User not found.");
                existingUser.UserName = userName;
                existingUser.Name = updatedUser.Name;
                existingUser.LName = updatedUser.LName;
                existingUser.Email = updatedUser.Email;
                existingUser.PNumber = updatedUser.PNumber;
                

                await _dbContext.SaveChangesAsync();
                
            }
            else
            {
                throw new (nameof(updatedUser));
            }
        }

        public async Task DeleteAsync(string userName)
        {
            var existingUser = await GetAsync(userName);
            if (existingUser != null)
            {
                _dbContext.Users.Remove(existingUser);
                await _dbContext.SaveChangesAsync();
            }

        }

        public async Task<UserEntity> GetAsync(string userName)
        {
            if (string.IsNullOrWhiteSpace(userName)) 
                throw new ArgumentNullException(nameof(userName), "User name cannot be null or empty.");

            return await _dbContext.Users.SingleOrDefaultAsync(u => u.UserName == userName)
                ?? throw new InvalidOperationException("User not found.");
        }
    }
}
