using Microsoft.AspNetCore.Mvc;
using Sipiyo.Models;

namespace Sipiyo.Services {
    public interface IUserService{
        Task<List<User>> GetUsersAsync();
    }
}