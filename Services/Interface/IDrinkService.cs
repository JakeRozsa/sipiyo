using Sipiyo.Models;

namespace Sipiyo.Services
{
    public interface IDrinkService{
        Task<List<Drink>> GetDrinksAsync();
    }
}