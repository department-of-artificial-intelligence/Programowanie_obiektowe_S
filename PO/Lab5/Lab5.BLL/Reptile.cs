using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Reptile : Animal
    {
        public bool CzyJadowity
        {
            get;
            set;
        }
        public Reptile(string jedzenie, int liczbaNog, string pochodzenie, string gatunek, bool czyJadowity) : base(jedzenie, liczbaNog, pochodzenie, gatunek)
        {
            CzyJadowity = czyJadowity;
        }
    }
}