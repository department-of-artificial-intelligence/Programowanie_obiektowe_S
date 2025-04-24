using System;
using System.Collections.Generic;
using System.Text;
using Generic.Extensions;

namespace Lab5.BLL
{
    public class Animal : IMovingMethod, IDisplayable 
    {
        protected string _foodType;
        protected int _legsCount;
        protected string _origin;
        protected string _species;

        public string FoodType
        {
            get => _foodType; set => _foodType = value;
        }
        public int LegsCount
        {
            get => _legsCount; set => _legsCount = value;
        }
        public string Origin
        {
            get => _origin; set => _origin = value;
        }
        public string Species
        {
            get => _species; set => _species = value;
        }

        public Zoo Zoo { get; set; }

        public Cage Cage
        {
            get; set;
        }

        public Animal(string foodType, int legsCount, string origin, string species)
        {
            FoodType = foodType ?? "no defined";
            LegsCount = legsCount;
            Origin = origin ?? "no defined";
            Species = species ?? "no defined";
        }
        public override string ToString()
        {
            return $" {GetType().Name}, {FoodType}, {LegsCount}, {Origin}, {Species}";
        }
    }
}