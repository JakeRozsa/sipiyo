using Sipiyo.Models;
using Sipiyo.Repository;

namespace Sipiyo.Services {

public class DrinkService{
    private readonly IDrinkRepository repo;
    public DrinkService(IDrinkRepository repository)
    {
        repo = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    public async Task<List<Drink>> GetDrinksAsync()
    {
        return await repo.GetDrinks();
    }
}
}