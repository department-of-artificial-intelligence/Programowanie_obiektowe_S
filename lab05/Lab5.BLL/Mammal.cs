using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Mammal:Animal
    {
        public string _enviroment;

        public string Enviroment 
        {  
            get { return _enviroment; }
            set { _enviroment = value; }
        }

        public Mammal() : base() { }

        public Mammal(string foodType, int legCount, string origin, string spieces, string Enviroment) : base(foodType, legCount, origin, spieces)
        {
            _enviroment = Enviroment;
        }




    }
}