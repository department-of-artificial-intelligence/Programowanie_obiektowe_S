using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Bird : Animal
    {
        private double _wingSpan;
        private double _endurance;

        public double WingSpan
        {
            get
            {
                return _wingSpan;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Wing span must be greater than zero");
                }
                else
                {
                    _wingSpan = value;
                }
            }

        }

        public double Endurance
        {
            get
            {
                return _endurance;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Endurance must be greater than zero");
                }
                else
                {
                    _endurance = value;
                }
            }

        }

        public double Fly()
        {
            return WingSpan * Endurance;
        }

        public Bird(string food, int legCount, string species, string origin, double wingSpan, double endurance) : base(food, legCount, species, origin)
        {
            WingSpan = wingSpan;
            Endurance = endurance;
        }
    }
}