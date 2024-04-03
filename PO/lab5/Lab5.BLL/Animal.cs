using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public abstract class Animal
    {
        protected string _foodType;
        protected int _legsCount;
        protected string _origin;
        protected string _species;
        public Animal(string foodType, int legsCount, string origin, string species)
        {
            _foodType = foodType;
            _legsCount = legsCount;
            _origin = origin;
            _species = species;
        }
    }
}