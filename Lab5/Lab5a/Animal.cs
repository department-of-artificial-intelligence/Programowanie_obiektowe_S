using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public abstract class Animal
    {
        private int _legCount;

        public string Species { get; set; }

        public string Origin { get; set; }

        public string Food { get; set; }

        public int LegCount
        {
            get
            {
                return _legCount;
            }
            set
            {
                if(value < 0) 
                {
                    throw new ArgumentOutOfRangeException("Leg count must be greater than zero");
                }
                else
                {
                    _legCount = value;
                }
            }
        }

        public Zoo Zoo
        {
            get => default;
            set
            {
            }
        }

        public Animal(string food, int legCount, string species, string origin)
        {
            Species = species;
            Origin = origin;
            Food = food;
            LegCount = legCount;
        }
    }
}