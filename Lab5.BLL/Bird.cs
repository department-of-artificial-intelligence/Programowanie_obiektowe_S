using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Generic.Extensions;

namespace Lab5.BLL
{
    public class Bird : Animal, IDisplayable
    {
        private double _wingSpan;
        private int _stamina;

        public Bird(string foodType, int legsCount, string origin, string species, double wingSpan, int stamina) : base(foodType, legsCount, origin, species)
        {
            _wingSpan = wingSpan;
            _stamina = stamina;
        }

        public void Fly()
        {
            System.Console.WriteLine($"{Species} is flying!");
        }

        public override string ToString()
        {
            return base.ToString() + $", Wingspan: {_wingSpan}, Stamina: {_stamina}";
        }
    }
}