using Generic.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Bird : Animal, IDisplayable
    {
        private double _rozpietoscSkrzydel;
        private double _wytrymalosc;

        public double RozpietoscSkrzydel { get=> _rozpietoscSkrzydel; set=> _rozpietoscSkrzydel = value; }

        public double Wytrymalosc { get => _wytrymalosc; set => _wytrymalosc = value; }

        public int wytrymalosc { get; set; }
        public Bird(string foodType, int legsCount, string orign, string specie, double rozpietoscSkrzydel, double wytrymalosc) : base(foodType,legsCount,orign,specie)
        {
            RozpietoscSkrzydel = rozpietoscSkrzydel;
            Wytrymalosc = wytrymalosc;
        }

        public double Fly()
        {
           Console.WriteLine("Fly:");
           return RozpietoscSkrzydel * Wytrymalosc;
        }

        public override string ToString()
        {
            return $"Bird: {base.ToString()}, RozpietoscSkrzydel:{RozpietoscSkrzydel}, Wytrymalosc:{Wytrymalosc}" ;
        }
    }
}