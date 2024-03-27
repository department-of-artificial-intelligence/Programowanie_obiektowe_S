using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PO_Lab5.BLL
{
    public class Animal : IMovingMethod
    {
        protected string _foodType;
        protected int _legsCount;
        protected string _origin;
        protected string _species;

        public string FoodType {  get => _foodType;  set =>  _foodType = value;  }
        public int LegsCount { get => _legsCount; set => _legsCount = value; }
        public string Origin { get => _origin; set => _origin = value; }
        public string Species { get => _species; set => _species = value; }
    }
}