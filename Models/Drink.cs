using MongoDB.Bson.Serialization.Attributes;

namespace Sipiyo.Models
{
    public class Drink
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string? Id {get; set;}
        public string Name {get; set;}  = null!;
        public string SodaBase {get; set;}  = null!;
        public List<string> AddIns  {get; set;} = null!;
        public Boolean Caffeinated {get; set;} = false!;
        public Boolean EnergyDrink {get; set;}
    }
}