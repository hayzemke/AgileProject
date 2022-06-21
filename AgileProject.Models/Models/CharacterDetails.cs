using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class CharacterDetails
{
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public bool IsEvil { get; set; }
    public Animal Animal { get; set; }
    public FarmerType FarmerType { get; set; }
    public GreenThumbLvl Level { get; set; }
}
