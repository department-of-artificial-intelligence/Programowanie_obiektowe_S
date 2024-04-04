using Generic.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Bird : Animal, IContainer
    {
        
        private int _legsCount;
        private double _wingspan;
        private double _stamina;
        public int LegsCount { get => _legsCount; set => _legsCount = value; }
        public double Wingspan { get => _wingspan; set => _wingspan = value; }
        public double Stamina { get => _stamina; set => _stamina = value; }

        public Bird(string nutrition, int legsCount, string origin, string species, double wingspan, double stamina)
            :base(nutrition, species, origin)
        {
            LegsCount = legsCount;
            Wingspan = wingspan;
            Stamina = stamina;
        }

        public void Fly()
        {
            double flyTime = Wingspan * Stamina;
            Console.WriteLine("Fly: " + flyTime);
            Console.WriteLine('\n');
        }

        public override string ToString()
        {
            var str = base.ToString();
            str += $"legs count: {LegsCount}, wingspan: {Wingspan}, stamina: {Stamina}";
            return str;
        }
    }
}