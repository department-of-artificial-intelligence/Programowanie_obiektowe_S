using Generic.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Bird : Animal, IDisplayable, IContainer
    {

        public double Wingspan
        {
        get; set;
        }

        public double Resilience
        {
            get; set;
        }

        public double Fly()
        {
            double Fly = Wingspan * Resilience;
            Console.WriteLine("Bird flied " + Fly + " kilometers");
            return Fly;
        }
        public Bird(string Foodtype, int Legscount, string oorigin, string species, double wingspan, double resilience)
    : base(Foodtype, Legscount, oorigin, species)
        {
            Resilience = resilience;
            Wingspan = wingspan;
        }
        public override string ToString()
        {
            base.ToString();
            Console.WriteLine($"Wingspan = {Wingspan}, Resilience = {Resilience}");
            return "";
        }

    }
}