using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Birds : Animal
    {
        private float _wingspan;
        private bool _venomous;

        public float maxFlightLen()
        {
            return _wingspan * (float)Stamina;
        }
    }
}