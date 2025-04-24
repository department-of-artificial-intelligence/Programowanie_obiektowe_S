using System;
using System.Collections.Generic;
using System.Text;
using Generic.Extensions;

namespace Lab5.BLL
{
    public class Bird : Animal
    {
        protected int _wingspan;
        protected double _strength;

        public double Strength
        {
            get => _strength; set => _strength = value;
        }

        public int Wingspan
        {
            get => _wingspan; set => _wingspan = value;
        }
        public Bird(string foodType, int legsCount, string origin, string species, double strength, int wingspan)
            : base(foodType, legsCount, origin, species)
        {
            Strength = strength;
            Wingspan = wingspan;
        }

        public double Fly()
        {
            return this.Strength * this.Wingspan;
        }

        public override string ToString()
        {
            return base.ToString() + $"{Strength}, {Wingspan}";
        }
    }
}