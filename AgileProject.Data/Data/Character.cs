using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

public class Character
{
    // public Character() {Farm = new Farm(); }

    [Key]
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    [Required]
    public string Name { get {
        return FirstName + LastName;
    }}
    public int Age { get; set; }
    public bool IsEvil { get; set; }
    public Animal Animal { get; set; }
    public FarmerType FarmerType { get; set; }
    public GreenThumbLvl Level { get; set; }
}