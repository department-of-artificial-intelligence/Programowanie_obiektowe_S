using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Mammal : Animal
    {
        private string _pochodzenieSsak {  get; set; }

        public Mammal(string rodajPokarmu, int ilośćNog, string pochodzenie, string gatunek, string pochodzeniSsak): 
            base(rodajPokarmu, ilośćNog, pochodzenie, gatunek)
        { 
            _pochodzenieSsak = pochodzeniSsak;
        }
    }
}