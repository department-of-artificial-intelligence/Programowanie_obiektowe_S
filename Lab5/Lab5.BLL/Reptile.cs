using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Generic.Extensions;

namespace Lab5.BLL
{
    public class Reptile: Animal, IDisplayable
    {
        private bool _isVenomous;

        public Reptile(string foodType, int legsCount, string origin, string species, bool isVenomous) : base(foodType, legsCount, origin, species)
        {
            _isVenomous = isVenomous;
        }

        public override string ToString()
        {
            return base.ToString() + $", IsVenomous: {_isVenomous}";
        }
    }
}