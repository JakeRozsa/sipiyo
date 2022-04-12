using Sipiyo.Models;

namespace Sipiyo.Repository;
public interface IUserRepository{
    Task<List<User>> GetUsers();
    Task AddUser(User user);
    Task<User> GetUserByEmail(string email);
    }