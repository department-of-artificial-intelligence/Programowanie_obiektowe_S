using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Generic.Extensions;

namespace Lab5.BLL
{
    public class Mammal : Animal, IDisplayable
    {
        public string Natural { get; set; }
        public Mammal() : base()
        {
            Natural = "";
        }
        public Mammal(string foodType, int legsCount, string origin, string species, string natural):base(foodType, legsCount, origin, species)
        {
            Natural= natural;
        }
        public override string ToString()
        {
            return $"{base.ToString()} {Natural} ";
        }
    }
}