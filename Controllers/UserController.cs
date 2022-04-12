using Sipiyo.Services;
using Sipiyo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Sipiyo.Controller
{
    public class UserController : ControllerBase
    {
        private readonly IUserService Service;
        public UserController(IUserService service)
        {
            Service = service ?? throw new ArgumentNullException(nameof(service));
        }
        [Route("api/Users")]
        // [HttpGet("users")]
        public async Task<IActionResult> GetUsersAsync(){
            var users = await Service.GetUsersAsync();
            return Ok(users);
        }
    }

}