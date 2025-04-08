using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.bll
{
    public abstract class Animal
    {
        public string FoodType;
        public string Origin;
        public string Species;
        public int LegsCount;
        public Animal(string foodtype,int legscount,string origin,string species)
        {
            FoodType = foodtype;
            Origin = origin;
            Species = species;
            LegsCount = legscount;
        }

        public override string ToString()
        {
            return $"Species: {Species},Origin: {Origin} LegsCount {LegsCount} FoodType: {FoodType}";
        }
    }
}