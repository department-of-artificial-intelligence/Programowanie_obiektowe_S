using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Reptile : Animal
    {
        public bool IsVenom { get; set; }

        public Reptile(string foodType, int legsCount, string species, string origin, bool isVenom)
            : base(foodType, legsCount, species, origin)
        {
            IsVenom = isVenom;
        }

        public override string ToString()
        {
            return "Reptile | " + base.ToString() + $", IsVenom: {IsVenom}";
        }

    }
}