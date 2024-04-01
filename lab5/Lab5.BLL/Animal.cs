using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Animal
    {
        private string _foodType;
        private int _legsCount;
        private string _origin;
        private string _species;
        public string FoodType { get { return _foodType; } set { _foodType = value; } }
        public int LegsCount { get { return _legsCount; } set { _legsCount = value; } }
        public string Origin { get { return _origin; } set { _origin = value; } }
        public string Species { get { return _species; } set { _species = value; } }
        public Animal()
        {
            FoodType= string.Empty;
            LegsCount= 0;
            Origin= string.Empty;
            Species= string.Empty;
        }
        public Animal(string foodType, int legsCount, string origin, string species)
        {
            FoodType = foodType;
            LegsCount = legsCount;
            Origin = origin;
            Species = species;
        }
        public override string ToString()
        {
            return $"{FoodType} {LegsCount} {Origin} {Species} ";
        }
    }
}