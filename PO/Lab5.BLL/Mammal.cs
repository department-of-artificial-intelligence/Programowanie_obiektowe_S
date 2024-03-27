using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PO_Lab5.BLL
{
    public class Mammal : Animal, IMovingMethod
    {
        private string _naturalOrigin;
        public string NaturalOrigin {  get => _naturalOrigin; set => _naturalOrigin = value; }
        public Mammal(string foodT, int legsc, string origin, string spec, string naturalorigin)
        {
            FoodType = foodT;
            LegsCount = legsc;
            Origin = origin;
            Species = spec;
            NaturalOrigin = naturalorigin;
        }
    }
}