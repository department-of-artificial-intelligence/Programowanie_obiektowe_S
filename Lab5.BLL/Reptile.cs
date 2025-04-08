using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Reptile : Animal
    {
        private bool _venomous;

        public Reptile(string foodType, int legCount, string origin, string species, bool venomous) : base(foodType, legCount, origin, species)
        {
            _venomous = venomous;
        }

        public void ToString()
        {
            throw new System.NotImplementedException();
        }
    }
}