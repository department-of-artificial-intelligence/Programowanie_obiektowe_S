using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Generic.Extensions;
namespace Lab5.BLL
{
    public class Mammal : Animal, IDisplayable
    {
        private string _naturalHabitat;

        public Mammal(string foodType, int legsCount, string origin, string species, string naturalHabitat) : base(foodType, legsCount, origin, species)
        {
            _naturalHabitat = naturalHabitat;
        }

        public override string ToString()
        {
            return base.ToString() + $", NaturalHabitat: {_naturalHabitat}";
        }
    }
}