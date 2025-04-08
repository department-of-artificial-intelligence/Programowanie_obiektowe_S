using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Animal
    {
        protected string _rodajPokarmu {  get; set; }
        protected string _pochodzenie { get; set; }
        protected int _iloscNog {  get; set; }
        protected string _gatunek { get; set; }

        public Animal(string rodajPokarmu, int ilośćNog, string pochodzenie,  string gatunek) 
        { 
            _rodajPokarmu = rodajPokarmu;
            _pochodzenie = pochodzenie;
            _iloscNog = ilośćNog; 
            _gatunek = gatunek;
        }

        public override string ToString()
        {
            return $"Aniemal | RodajPokarmu: {_rodajPokarmu}, Pochodzenie: {_pochodzenie}, IloscNog: {_iloscNog}, Gatunek: {_gatunek}";
        }
    }
}