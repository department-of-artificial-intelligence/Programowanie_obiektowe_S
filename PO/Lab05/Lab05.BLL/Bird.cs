using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab05.BLL
{
    public class Bird : Animal
    {
        protected double _wingspan;
        protected double _strength;

        public double maxFlight()
        {
            return _wingspan * _strength;
        }
    }
}