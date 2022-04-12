using MongoDB.Driver;
using Sipiyo.Models;

namespace Sipiyo.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IMongoCollection<User> userCollection;
        public UserRepository(IMongoDBContext context)
        {
            userCollection = context.GetCollection<User>("User");
        }
        public async Task<List<User>> GetUsers(){
            return await userCollection.Find(_=>true).ToListAsync();
        }
    }
}