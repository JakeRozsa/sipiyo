using Sipiyo.Services;
using Sipiyo.Models;
using Microsoft.AspNetCore.Mvc;
using sipiyo.Controllers;
using System.Security.Cryptography;
using System.Text;
using sipiyo.DTOs;
using Sipiyo.Services.Interface;
using Sipiyo.DTOs;

namespace Sipiyo.Controller
{
    public class UsersController : BaseApiController
    {
        private readonly IUserService Service;
        private readonly ITokenService TokenService;

        public UsersController(IUserService service, ITokenService tokenService)
        {
            Service = service ?? throw new ArgumentNullException(nameof(service));
            TokenService = tokenService;
        }
        public async Task<IActionResult> GetUsersAsync(){
            var users = await Service.GetUsersAsync();
            return Ok(users);
        }


        [HttpPost("register")]
        public async Task<ActionResult<UserDto>> Register(RegisterDto registerDto)
        {
            var userExists = await Service.GetUserByEmail(registerDto.Email);

            if (userExists != null) return Unauthorized("That email is taken");

            using var hmac = new HMACSHA512();

            var user = new User
            {
                Email = registerDto.Email,
                FirstName = registerDto.FirstName,
                LastName = registerDto.LastName,
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(registerDto.Password)),
                PasswordSalt = hmac.Key
            };
            await Service.AddUser(user);

            return new UserDto
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Token = TokenService.CreateToken(user)
            };
        }


        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> Login(LoginDto loginDto)
        {
            var user = await Service.GetUserByEmail(loginDto.Email);

            if (user == null) return Unauthorized("Invalid email");

            using var hmac = new HMACSHA512(user.PasswordSalt);

            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(loginDto.Password));

            for (int i = 0; i < computedHash.Length; i++)
            {
                if (computedHash[i] != user.PasswordHash[i]) return Unauthorized("Invalid password");
            }

            return new UserDto
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Token = TokenService.CreateToken(user)
            };
        }
    }

}