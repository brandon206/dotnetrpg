using System.Text.Json.Serialization;
namespace dotnet_rpg.Models
{
  [JsonConverter(typeof(JsonStringEnumConverter))]
  public enum RpgClass
  {
    Phyrexian = 1,
    Mage = 2,
    Human = 3,
    Elf = 4,
    Zombie = 5
  }
}