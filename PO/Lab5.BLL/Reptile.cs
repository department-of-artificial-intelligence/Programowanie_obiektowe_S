using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PO_Lab5.BLL
{
    public class Reptile : Animal, IMovingMethod
    {
        private bool _poison;
        public bool Poison {  get => _poison; set => _poison = value; }

        public Reptile(string food, int legs, string origin, string species, bool poison)
        {
            FoodType = food;
            LegsCount = legs;
            Origin = origin;
            Species = species;

            Poison = poison;
        }
    }
}