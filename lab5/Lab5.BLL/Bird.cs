using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Generic.Extensions;

namespace Lab5.BLL
{
    public class Bird : Animal, IDisplayable
    {
        public double WingScope {  get; set; }
        public int Endurance {  get; set; }
        public Bird(string foodType, int legsCount, string origin, string species, double wingScope, int endurance) :base(foodType, legsCount, origin, species) 
        {
            WingScope = wingScope;
            Endurance = endurance;
        }
        public double Fly()
        {
            return WingScope*Endurance;
        }
        public override string ToString()
        {
            return $"{base.ToString()} {WingScope} {Endurance} ";
        }
    }
}