using Sipiyo.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Sipiyo.Repository;

public interface IMongoDBContext {
    IMongoCollection<T> GetCollection<T>(string collectionName);
};
public class MongoDBContext : IMongoDBContext {
    private readonly IMongoDatabase database;

    public MongoDBContext(IOptions<MongoDBSettings> mongoDBSettings) {
        MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
        database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
    }

    public IMongoCollection<T> GetCollection<T>(string collectionName){
        return database.GetCollection<T>(collectionName);
    }

}