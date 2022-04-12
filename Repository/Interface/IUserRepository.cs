using Sipiyo.Models;

namespace Sipiyo.Repository;
public interface IUserRepository{
    Task<List<User>> GetUsers(); 
    }