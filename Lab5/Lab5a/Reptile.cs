using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Reptile : Animal
    {

        public bool IsVenomous { get; set;}
        public Reptile(string food, int legCount, string species, string origin, bool isVenomous) : base(food, legCount,species, origin)
        {
            IsVenomous = isVenomous;
        }

    }
}