using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class CharacterEdit
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    // public string Name { get {
    //     return FirstName +" "+ LastName;
    // }}
    //this ^ would be a readonly, and as a character (and such a creation) it isn't needed
    public int Age { get; set; }
    public bool IsEvil { get; set; }
    //As a reminder, get=read and set=write
    public Animal Animal { get; set; }
    public FarmerType FarmerType { get; set; }
}