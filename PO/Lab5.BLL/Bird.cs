using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PO_Lab5.BLL
{
    public class Bird : Animal, IMovingMethod
    {
        private float _wingsScope; //razmah
        private int _endurance;

        public float WingsScope {  get { return _wingsScope; } set { _wingsScope = value; } }
        public int Endurance {  get { return _endurance; } set { _endurance = value; } }

        public float FlightLength()
        {
            return WingsScope * Endurance;
        }
    }
}