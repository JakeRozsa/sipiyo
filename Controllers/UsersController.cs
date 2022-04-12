using Sipiyo.Services;
using Sipiyo.Models;
using Microsoft.AspNetCore.Mvc;
using sipiyo.Controllers;

namespace Sipiyo.Controller
{
    public class UsersController : BaseApiController
    {
        private readonly IUserService Service;
        public UsersController(IUserService service)
        {
            Service = service ?? throw new ArgumentNullException(nameof(service));
        }
        public async Task<IActionResult> GetUsersAsync(){
            var users = await Service.GetUsersAsync();
            return Ok(users);
        }
    }

}