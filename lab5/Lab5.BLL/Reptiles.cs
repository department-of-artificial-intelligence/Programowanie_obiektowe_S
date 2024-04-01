using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Reptile : Animal
    {
        public bool Jadowitosc {  get; set; }
        public Reptile():base() 
        {
            Jadowitosc = false;
        }
        public Reptile(string foodType, int legsCount, string origin, string species, bool jadowitosc):base(foodType, legsCount, origin, species) 
        {
            Jadowitosc = jadowitosc;
        }
        public override string ToString()
        {
            return $"{base.ToString()} {Jadowitosc} ";
        }
    }
}