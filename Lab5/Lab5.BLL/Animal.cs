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

        public string FoodType { get => _foodType; set => _foodType = value; }
        private int LegsCount { get => _legsCount; set => _legsCount = value; }
        public string Origin { get => _origin; set => _origin = value; }
        public string Species { get => _species; set => _species = value; }

        public Animal(string foodType, int legsCount, string species, string origin)
        {
            FoodType = foodType;
            LegsCount = legsCount;
            Origin = origin;
            Species = species;
        }

        public override string ToString()
        {
            return $"Animal | FoodType: {FoodType}, LegsCount: {LegsCount}, Origin: {Origin}, Species: {Species}";
        }
    }
}