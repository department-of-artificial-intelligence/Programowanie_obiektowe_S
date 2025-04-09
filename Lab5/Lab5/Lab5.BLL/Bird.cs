using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Bird : Animal
    {
        private bool _fly;
        private double _flightLength;
        private double _wingspan;
        private double _endurance;


        public Bird(string foodType, int number, string origin, string specie, double wingspan, double endurance) : base(foodType, number, origin, specie)
        {
            _wingspan=wingspan;
            _endurance=endurance;
            _flightLength=_wingspan*_endurance;
        }
    }


}