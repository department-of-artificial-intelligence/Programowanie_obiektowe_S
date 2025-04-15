using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Lab5.BLL
{
    public class Animal
    {
        public string _foodType;
        public int _legCount;
        public string _origin;
        public string _spieces;


        public string FoodType
        {
            get { return _foodType; }
            set { _foodType = value; }
        }

        public int LegCount
        {
            get { return _legCount; }
            set { _legCount = value; }
        }

        public string Origin
        {
            get { return _origin; }
            set { _origin = value; }
        }

        public string Spieces
        {
            get { return _spieces; }
            set { _spieces = value; }
        }




        public Animal() { }

        public Animal(string foodType, int legCount, string origin, string spieces)
        {
            _foodType = foodType;
            _legCount = legCount;
            _origin = origin;
            _spieces = spieces;
        }


    }
}