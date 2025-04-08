using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.bll
{
    public class Mammal : Animal
    {
        public string Environment;
        public Mammal(string foodtype,int footcount,string origin ,string species,string environment):base(foodtype,footcount,origin,species)
        {
            Environment = environment;
        }
        public override string ToString()
        {
            return base.ToString() + $"Environment : {Environment}\n";
        }

    }
}