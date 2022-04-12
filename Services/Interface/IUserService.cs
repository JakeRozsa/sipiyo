using Sipiyo.Models;

namespace Sipiyo.Services {
    public interface IUserService{
        Task<List<User>> GetUsersAsync();
        Task<User> GetUserByEmail(string email);
        Task AddUser(User user);
    }
}