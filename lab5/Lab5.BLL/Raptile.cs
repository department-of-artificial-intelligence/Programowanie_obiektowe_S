using System;
using System.Collections.Generic;
using System.Text;
using Generic.Extensions;

namespace Lab5.BLL
{
    public class Reptile : Animal
    {
        protected bool _venomous;

        public bool Venomous
        {
            get => _venomous; set => _venomous = value;
        }
        public Reptile(string foodType, int legsCount, string origin, string species, bool venomous)
            : base(foodType, legsCount, origin, species)
        {
            Venomous = venomous;
        }
        public override string ToString()
        {
            return base.ToString() + $"{Venomous}";
        }
    }
}