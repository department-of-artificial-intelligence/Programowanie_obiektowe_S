using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Bird : Animal
    {
        private double _wingspan;
        private double _stamina;

        public Bird(string foodType, int legs, string origin, string species, double stamina, double wingSpan)
            : base(foodType, legs, origin, species)
        {
            _wingspan = wingSpan;
            _stamina = stamina;
        }

        public void Fly()
        {
            double flight = _stamina * _wingspan;
            Console.WriteLine($"{Species} can fly during {flight} km");
        }

        public override string ToString()
        {
            return $"Mammal | " + base.ToString() + $", Stamina: {_stamina}, WingSpan: {_wingspan}";
        }
    }
}