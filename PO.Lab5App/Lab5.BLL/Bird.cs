using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Bird : Animal
    {
        protected double _wingspan;
        protected int _endurance;
        public double Wingspan { get=>_wingspan; set=> _wingspan=value; }

        public int Endurance { get=>_endurance; set=>_endurance=value; }

        public Bird(string foodType, int legsCount,
            string origin, string species,
            double wingspan,int endurance) : base(foodType, legsCount, origin, species)
        {
            Wingspan = wingspan;
            Endurance = endurance;
        }

        public void Fly()
        {
            Console.WriteLine($"Maximum flight length : {Wingspan * Endurance}m");
        }
    }
}