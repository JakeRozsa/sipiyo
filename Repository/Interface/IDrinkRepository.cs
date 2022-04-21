using Sipiyo.Models;

public interface IDrinkRepository
    {
        Task<List<Drink>> GetDrinks();
        Task<Drink> GetDrinkByName(string name);
    }