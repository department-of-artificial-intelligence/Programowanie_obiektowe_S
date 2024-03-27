using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Mammal : Animal
    {
        public string NaturalneSrodowisko
        {
            get;
            set;
        }
        public Mammal(string jedzenie, int liczbaNog, string pochodzenie, string gatunek, string naturalneSrodowisko):base(jedzenie,liczbaNog,pochodzenie,gatunek) 
        {
            NaturalneSrodowisko = naturalneSrodowisko;
        }
    }
}