using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.bll
{
    public class Reptile : Animal
    {
        public bool IsPoisonous;

        public Reptile(string foodtype, int footcount, string origin, string species, bool isPoisonous):base(foodtype, footcount, origin, species)
        {
            IsPoisonous = isPoisonous;
        }

        public override string ToString()
        {
            return base.ToString()+$"Is it poisonous? : {IsPoisonous}\n";
        }
    }
}