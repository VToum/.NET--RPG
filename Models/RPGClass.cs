using System.Text.Json.Serialization;

namespace Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RPGClass
    {
        Knight = 1,
        Paladin = 2,
        Sorcerer = 3,
        Druid = 4
    }
}