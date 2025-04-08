using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Reptile : Animal
    {
        private bool _jadowity {  get; set; }

        public Reptile(string rodajPokarmu, int ilośćNog, string pochodzenie, string gatunek, bool jadowity) :
            base(rodajPokarmu, ilośćNog, pochodzenie, gatunek)
        { 
            _jadowity = jadowity;
        }
    }
}