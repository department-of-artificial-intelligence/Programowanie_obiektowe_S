using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Mammal : Animal
    {
        private string _naturalHabitat;

        public Mammal(string foodType, int legCount, string origin, string species, string naturalHabitat) : base(foodType, legCount, origin, species)
        {
            _naturalHabitat = naturalHabitat;
        }

        public string ToString()
        {
            throw new System.NotImplementedException();
        }
    }
}