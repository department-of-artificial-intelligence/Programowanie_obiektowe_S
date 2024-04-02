using Generic.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Reptile : Animal, IDisplayable, IContainer
    {

        public bool Poison
        {
            get => default;
            set
            {
            }
        }
        public Reptile(string Foodtype, int Legscount, string oorigin, string species, bool poison)
    : base(Foodtype, Legscount, oorigin, species)
        {
            Poison = poison;
        }
        public override string ToString()
        {
            base.ToString();
            Console.WriteLine($"Poison = {Poison}");
            return "";
        }
    }
}