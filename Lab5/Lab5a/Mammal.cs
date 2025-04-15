using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Mammal : Animal
    {
        public string NaturalHabitat { get; set; }

        public Mammal(string food, int legCount, string species, string origin,string naturalHabitat) : base(food, legCount, species, origin)
        {
            NaturalHabitat = naturalHabitat;
        }
    }
}