using Sipiyo.Models;

public interface IDrinkRepository
    {
        Task<List<Drink>> GetDrinks();
    }