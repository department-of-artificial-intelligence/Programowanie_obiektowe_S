using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gosha
{
    public class Mammal : Animal
    {
        public string Origin { get; set; }
        public Mammal(string diet, int legs, string habitat, string species, string origin) : base(diet, legs, habitat, species)
        {
            Origin = origin;
        }
    }
}