using System.Text.Json.Serialization;

namespace dotnet_rpg_6.Entities
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgCharacter
    {
        Mage =1,
        Knight = 2,
        Cleric = 3,
    }
}
