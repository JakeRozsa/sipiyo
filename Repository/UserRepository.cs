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

        public async Task AddUser(User user)
        {
            await userCollection.InsertOneAsync(user);
        }

        public async Task<List<User>> GetUsers(){
            return await userCollection.Find(_=>true).ToListAsync();
        }

        public async Task<User> GetUserByEmail(string email)
        {
            return await userCollection.Find(x => x.Email == email).FirstOrDefaultAsync();
        }
    }
}