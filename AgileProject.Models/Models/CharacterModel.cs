using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class CharacterModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Name { get {
        return FirstName + LastName;
    }}
    public int Age { get; set; }
    public bool IsEvil { get; set; }
}