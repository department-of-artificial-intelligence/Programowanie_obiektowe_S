using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Mammal : Animal
    {
        public string Origin
        {
            get => default;
            set
            {
            }
        }
        public Mammal(string Foodtype, int Legscount, string oorigin, string species, string origin)
            :base(Foodtype,Legscount, oorigin, species)
        {
            Origin = origin;
        }
    }
}