using MongoDB.Driver;
using Sipiyo.Models;

namespace Sipiyo.Repository
{
    
    public class DrinkRepository : IDrinkRepository
    {
        private readonly IMongoCollection<Drink> drinkCollection;
        public DrinkRepository(IMongoDBContext context)
        {
            drinkCollection = context.GetCollection<Drink>("Drink");
        }

        public async Task<List<Drink>> GetDrinks()
        {
            return await drinkCollection.Find(_=> true).ToListAsync();
        }

        public Task<Drink> GetDrinkByName(string name)
        {
            return drinkCollection.Find(x => x.Name == name).FirstOrDefaultAsync();
        }
    }
}