using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Models
{
  public class Character
  {
    public int Id { get; set; }
    public string Name { get; set; } = "Elesh Norn";
    public int Health { get; set; } = 100;
    public int Strength { get; set; } = 7;
    public int Intelligence { get; set; } = 10;
    public RpgClass Class { get; set; } = RpgClass.Phyrexian;
  }
}