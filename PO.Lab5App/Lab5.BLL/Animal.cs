using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Animal : IMovingMethod
    {
        protected string _foodType;
        protected int _legsCount;
        protected string _origin;
        protected string _species;

        public int LegsCount { get => _legsCount; set => _legsCount=value; }
        public string Species { get => _species; set => _species=value; }
        public string Origin { get => _origin; set => _origin=value; }
        public string FoodType { get=>_foodType; set => _foodType=value; }
        public Animal(string foodType, int legsCount, string origin, string species)
        {
            FoodType = foodType;
            LegsCount = legsCount;
            Origin = origin;
            Species = species;
        }
        public override string ToString()
        {
            return $"{FoodType} {LegsCount} {Origin} {Species}";
        }
    }
}