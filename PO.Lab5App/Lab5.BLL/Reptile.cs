using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Reptile : Animal
    {
        protected bool _isVenomous;
        public bool IsVenomous { get => _isVenomous; set => _isVenomous = value; }

        public Reptile(string foodType, int legsCount, string origin, string species, bool isV) : base(foodType, legsCount, origin, species)
        {
            IsVenomous = isV;
        }
    }
}