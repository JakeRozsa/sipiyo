using Sipiyo.Models;

namespace Sipiyo.Services
{
    public interface IDrinkService{
        Task<List<Drink>> GetDrinksAsync();
        Task<Drink> GetDrinkByName(string name);
        Task<List<Drink>> GetCaffeinatedDrinks();
    }
}