using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Animal : IMovingMethod
    {
        protected string _species;
        protected string _foodType;
        protected string _origin;
        protected int _legCount;

        public Animal(string foodType, int legCount, string origin, string species)
        {
            throw new System.NotImplementedException();
        }

        public void ToString()
        {
            throw new System.NotImplementedException();
        }

        public override int LegCount
        { get; set; }
    }
}