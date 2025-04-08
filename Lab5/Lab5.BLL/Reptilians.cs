using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Reptile : Animal
    {
        private bool _venomous;
        public bool Venomous { get { return _venomous; } set { _venomous = value; } }

        public Reptile(string foodType, int legs, string origin, string species, bool ven) 
            : base(foodType, legs, origin, species)
        {
            _venomous = ven;
        }

        public override string ToString()
        {
            string flag = "";
            if (_venomous == false) flag = "not";
            
            return $"Reptile | " + base.ToString() + $", is {flag} venomous";
        }
    }
}