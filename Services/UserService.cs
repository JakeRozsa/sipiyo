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
        public async Task<List<User>> GetUsersAsync()
        {
            return await repo.GetUsers();
        }

    }
}