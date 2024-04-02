using Generic.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Mammal : Animal, IDisplayable, IContainer
    {
        public string Origin
        {
            get;set;
        }
        public Mammal(string Foodtype, int Legscount, string oorigin, string species, string origin)
            :base(Foodtype,Legscount, oorigin, species)
        {
            Origin = origin;
        }
        public override string ToString()
        {
            base.ToString();
            Console.WriteLine($"Origin = {Origin}");
            return "";
        }
    }
}