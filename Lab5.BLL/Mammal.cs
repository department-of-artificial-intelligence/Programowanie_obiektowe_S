using System;
using System.Collections.Generic;
using System.Text;
using Generic.Extensions;

namespace Lab5.BLL
{
    public class Mammal : Animal
    {
        protected string _naturalHabitat;

        public string NaturalHabitat
        {
            get => _naturalHabitat; set => _naturalHabitat = value;
        }

        public Mammal(string foodType, int legsCount, string origin, string species, string naturalHabitat)
            : base(foodType, legsCount, origin, species)
        {
            NaturalHabitat = naturalHabitat ?? string.Empty;
        }

        public override string ToString()
        {
            return base.ToString() + $", Natural habitat: {NaturalHabitat}";
        }
    }
}