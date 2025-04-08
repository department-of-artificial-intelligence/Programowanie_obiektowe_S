using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Mammal : Animal
    {
        private string _country;

        public Mammal(string foodType, int legs, string origin, string species, string country) 
            : base(foodType, legs, origin, species)
        {
            _country = country;
        }

        public override string ToString()
        {
            return $"Mammal | " + base.ToString() + $", 2. Country(XDD) {_country}";
        }
    }
}