using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Mammal : Animal
    {
        protected string _naturalEnviroment;
        public string NaturalEnviroment { get=>_naturalEnviroment; set=>_naturalEnviroment=value; }
        public Mammal(string foodType, int legsCount, string origin, string species, string naturalEnviroment)
            :base(foodType,legsCount,origin,species)
        {
            NaturalEnviroment=naturalEnviroment;
        }
    }
}