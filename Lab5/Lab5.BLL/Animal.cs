using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Animal : IMovingMethod
    {
        protected int _foodType;
        protected int _legsCount;
        protected int _origin;
        protected int _species;
    }
}