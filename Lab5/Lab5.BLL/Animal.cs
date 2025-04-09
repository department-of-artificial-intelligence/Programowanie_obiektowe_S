using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.BLL
{
    public class Animal : Zoo, IMovingMethod
    {
        protected string _foodType;
        protected int _legsCount;
        protected string _origin;
        protected string _species;
    }
}