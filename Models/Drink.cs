using MongoDB.Bson.Serialization.Attributes;

namespace Sipiyo.Models
{
    public class Drink
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? Id {get; set;}
        public string Name {get; set;}  = null!;
        public List<string> SodaBase {get; set;}  = null!;
        public List<string> AddIns  {get; set;} = null!;
        public Boolean Caffeinated {get; set;}
        public Boolean EnergyDrink {get; set;}
    }
}