using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.BLL
{
    public class Bird : Animal
    {
        protected double _wingspan;
        protected int _stamina;

        public double Wingspan
        {
            get => _wingspan; set => _wingspan = value;
        }

        public int Stamina
        {
            get => _stamina; set => _stamina = value;
        }

        public Bird(string foodType, int legsCount, string origin, string species, double wingspan, int stamina)
            : base(foodType, legsCount, origin, species)
        {
            Wingspan = wingspan;
            _stamina = stamina;
        }

        public double Fly()
        {
            double maxDistance = Wingspan * Stamina;
            Console.WriteLine($"{Species} is flying for up to {maxDistance} meters!");
            return maxDistance;
        }

        public override string ToString()
        {
            return base.ToString() + $", Wingspan: {Wingspan}, Stamina: {Stamina}";
        }
    }
}