using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BBL
{
    public class Reptile : Animal
    {
        public Reptile(string name, int numberOfLegs, string nutrition, string origin, bool venomous) : base(name, numberOfLegs, nutrition, origin)
        {
            Venomous = venomous;
        }

        public bool Venomous
        {
            get => default;
            set
            {
            }
        }
    }
}