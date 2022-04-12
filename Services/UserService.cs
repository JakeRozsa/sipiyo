using Sipiyo.Repository;
using Sipiyo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Sipiyo.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository repo;
        public UserService(IUserRepository repository)
        {
            repo = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task AddUser(User user)
        {
            await repo.AddUser(user);
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await repo.GetUsers();
        }

        public async Task<User> GetUserByEmail(string email)
        {
            return await repo.GetUserByEmail(email);
        }
    }
}