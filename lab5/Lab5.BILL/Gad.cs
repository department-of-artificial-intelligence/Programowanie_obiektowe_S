using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gosha
{
    public class Reptile : Animal
    {
        public bool IsVenomous { get; set; }
        public Reptile(string diet, int legs, string habitat, string species, bool isVenomous) : base(diet, legs, habitat, species)
        {
            IsVenomous=isVenomous;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Venom?: {IsVenomous}";
        }
    }
}