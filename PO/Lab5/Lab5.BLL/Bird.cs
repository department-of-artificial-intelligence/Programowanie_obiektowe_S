using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Bird : Animal
    {
        public double RozpietoscSkrzydel
        {
            get;
            set;
        }

        public int Wytrzymałość
        {
            get;
            set;
        }
        public Bird() : base() { RozpietoscSkrzydel = 0;Wytrzymałość = 0; }
        public Bird(string jedzenie, int liczbaNog, string pochodzenie, string gatunek, double rozpietoscSkrzydel, int wytrzymalosc) : base(jedzenie, liczbaNog, pochodzenie, gatunek) { RozpietoscSkrzydel = rozpietoscSkrzydel; Wytrzymałość = wytrzymalosc; }
        
        public void Fly()
        {
            Console.WriteLine($"Ptak przelecial {RozpietoscSkrzydel * Wytrzymałość} metrow.");
        }
    }
}