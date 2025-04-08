using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.bll
{
    public class Bird : Animal
    {
        public double WingsSize;
        public double Stamina;

        public Bird(string foodtype, int footcount, string origin, string species,double wingsSize,int stamina) : base(foodtype, footcount, origin, species)
        {
            WingsSize = wingsSize;
            Stamina = stamina;
        }

        public double FlightTime(double wingSize,double stamina)
        {
            double flight = wingSize * stamina;
            return flight;
        }

        public void Fly()
        {
            Console.WriteLine($"Ptak {this.Species} leci {FlightTime(WingsSize,Stamina)} czasu");
        }

        public override string ToString()
        {
            return base.ToString() + $"WingsSize: {WingsSize} Stamina: {Stamina}\n" ;
        }
    }
}