using System;
using System.Collections.Generic;
using System.Text;
using Generic.Extensions;

namespace Lab5.BLL
{
    public class Reptile : Animal
    {
        protected bool _isVenomous;

        public bool IsVenomous
        {
            get => _isVenomous; set => _isVenomous = value;
        }

        public Reptile(string foodType, int legsCount, string origin, string species, bool isVenomous)
            : base(foodType, legsCount, origin, species)
        {
            IsVenomous = isVenomous;
        }

        public override string ToString()
        {
            return base.ToString() + $", Venomous: {IsVenomous}";
        }
    }
}