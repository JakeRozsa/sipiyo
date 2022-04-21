using Sipiyo.Models;
using Sipiyo.Repository;

namespace Sipiyo.Services {

public class DrinkService : IDrinkService
{
    private readonly IDrinkRepository repo;
    public DrinkService(IDrinkRepository repository)
    {
        repo = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    public async Task<List<Drink>> GetDrinksAsync()
    {
        return await repo.GetDrinks();
    }

    public Task<Drink> GetDrinkByName(string name)
    {
        return repo.GetDrinkByName(name);
    }
    public Task<List<Drink>> GetCaffeinatedDrinks()
    {
List<Sipiyo.Models.Drink> allDrinks = repo.GetDrinks();

    }
}
}