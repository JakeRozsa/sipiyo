using Sipiyo.Models;

namespace Sipiyo.Services.Interface
{
    public interface ITokenService
    {
        string CreateToken(User user);
    }
}
