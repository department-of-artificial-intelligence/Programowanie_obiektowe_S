using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Lab5.BLL
{
    public class Animal
    {
        private string _foodType;
        private int _legsCount;
        private string _origin;
        private string _species;

        public string Species { get { return _species; } set { _species = value; }  }

        public Animal(string foodType, int legsCount, string origin, string species)
        {
            _foodType = foodType;
            _legsCount = legsCount;
            _origin = origin;
            _species = species;
        }

        public override string ToString()
        {
            return $"FoodType: {_foodType}, LegsCount: {_legsCount}, Origin: {_origin}, Species: {_species}";
        }
    }
}