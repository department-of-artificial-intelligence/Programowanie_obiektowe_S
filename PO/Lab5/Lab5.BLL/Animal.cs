using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Animal
    {

        public string FoodType
        {
            get; set;
        }

        public int LegsCount
        {
            get; set;
        }

        public string OOrigin
        {
            get; set;
        }

        public string Species
        {
            get; set;
        }
        public Animal(string Foodtype, int Legscount, string origin, string species)
        {
            FoodType = Foodtype;
            LegsCount = Legscount;
            OOrigin = origin;
            Species = species;
        }
    }
}