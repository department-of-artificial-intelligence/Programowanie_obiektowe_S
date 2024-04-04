using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BBL
{
    public class Bird : Animal
    {
        public Bird(string name, int numberOfLegs, string nutrition, string origin,double endurance, int wingSpan) : base(name, numberOfLegs, nutrition, origin)
        {
            Endurance = endurance;
            WingSpan = wingSpan;
        }

        public int WingSpan
        {
            get;
            set;
        }

        public double Endurance
        {
            get;
            set;
        }


        public void Fly()
        {
            Console.WriteLine(WingSpan*Endurance);
        }
        public override string ToString()
        {
            return base.ToString()+ $"WingSpan: {WingSpan}, Endurance: {Endurance}";
        }
    }
}