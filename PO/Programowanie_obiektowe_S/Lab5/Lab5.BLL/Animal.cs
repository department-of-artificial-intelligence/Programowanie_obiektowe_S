using Generic.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Animal : IMovingMethod,IDisplayable
    {
        protected string _foodType;
        protected int _legsCount;
        protected string _orign;
        protected string _species;

        public string foodType { get { return _foodType; } set {  _foodType = value; } }

        public  int LegsCount { get { return _legsCount; } set { _legsCount = value; } }

        public string orign { get { return _orign; } set { _orign = value; } }
        public string species { get { return _species;} set { _species = value; } }

        public Animal()
        {
            foodType = string.Empty;
            species = string.Empty;
            LegsCount = 0;
            orign = string.Empty;
        }

        public Animal(string foodType, int legsCount, string orign, string species) {
            _foodType = foodType;
            _legsCount = legsCount;
            _orign = orign;
            _species = species;
        }

        public override string ToString()
        {
            return $"FoodType: {foodType}, LegsCount: {LegsCount}, Orign:{orign}, Species:{species}";
        }



       
    }
}