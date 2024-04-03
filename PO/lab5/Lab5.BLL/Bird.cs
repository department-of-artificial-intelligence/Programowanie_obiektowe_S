using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Bird : Animal
    {
        private double _wingspan;
        private int _endurance;

        public double Fly(int endurance, double wingspan)
        {
            return endurance * wingspan;
        }
        public Bird(string foodType, int legsCount, string origin, string species, int endurance, double wingspan) : base(foodType,legsCount,origin,species)
        {
            _wingspan = wingspan;
            _endurance = endurance;

    }
    }
}