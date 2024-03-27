using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Mammal : Animal
    {
        public string Area { get; set; }
        
        public Mammal(string foodType, int legsCount, string origin, string species, string area)
            : base(foodType, legsCount, origin, species)
        {
            Area = area;
        }
        public override string ToString()
        {
            return "Mammal | " + base.ToString() + $" Area: {Area}";
        }
    }
}