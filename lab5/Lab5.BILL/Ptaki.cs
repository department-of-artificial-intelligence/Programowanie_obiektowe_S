using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gosha
{
    public class Bird : Animal
    {
        public double WingSpan { get; set; }
        public double Endurance {  get; set; }
        public Bird(string diet, int legs, string habitat, string species, string origin, double wingSpan, double endurance) : base(diet, legs, habitat, species, origin)
        {
            
            WingSpan = wingSpan;
            Endurance = endurance;

        }
        public void Fly()
        {
            Console.WriteLine($"{Species} is flying with wingspan {WingSpan} m and endurance {Endurance}");
        }
    }
}