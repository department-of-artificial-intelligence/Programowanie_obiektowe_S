using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BBL
{
    public class Mammal : Animal
    {
        public string NaturalHabitat
        {
            get;
            set;
        }
        public Mammal(string name, int numberOfLegs, string nutrition, string origin,string naturalHabitat) : base(name, numberOfLegs, nutrition, origin)
        {
            NaturalHabitat = naturalHabitat;
        }

       
    }
}