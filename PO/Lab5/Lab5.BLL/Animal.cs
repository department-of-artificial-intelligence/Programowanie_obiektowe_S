using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public abstract class Animal
    {

        public string Pochodzenie
        {
            get;
            set;
        }

        public int LiczbaNog
        {
            get;
            set;
        }

        public string Jedzenie
        {
            get;
            set;
        }

        public string Gatunek
        {
            get;
            set;
        }

        public Animal() { Pochodzenie = ""; LiczbaNog = 0; Jedzenie = ""; Gatunek = ""; }
        public Animal(string jedzenie, int liczbaNog, string pochodzenie, string gatunek)
        {
            Jedzenie = jedzenie;
            LiczbaNog = liczbaNog;
            Pochodzenie = pochodzenie;
            Gatunek = gatunek;
        }
        public override string ToString()
        {
            return Gatunek;
        }
    }
}