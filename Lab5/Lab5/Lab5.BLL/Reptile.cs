using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Reptile : Animal
    {
        private bool _venomous;

        public Reptile(string foodType, int number, string origin, string specie, bool venomous): base(foodType, number, origin, specie)
        {
            _venomous=venomous;
        }
    }
}