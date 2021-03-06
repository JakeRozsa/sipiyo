using MongoDB.Bson.Serialization.Attributes;

namespace Sipiyo.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? Id {get; set;} 
        public string FirstName {get; set;} = null!;
        public string LastName {get; set;} = null!;
        public string Email {get; set;} = null!;
        public byte[] PasswordHash { get; set; } = null!;
        public byte[] PasswordSalt { get; set; } = null!;

    }
}