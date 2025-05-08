using laboratorium5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorium5
{
    public class Bird: Animal
    {
        private double _wingsLength;
        private double _stamina;

        public Bird(string foodType, int legsCount, string origin, string spieces, double wingsL, double stamina): base(foodType, legsCount, origin, spieces)
        {
            _wingsLength = wingsL;
            _stamina = stamina;
        }
        public double MaxDistance()
        {
            return _wingsLength * _stamina;
        }

        public void Fly()
        {
            Console.WriteLine($"Bird can fly distance: {MaxDistance()}");
        }

        public override string ToString()
        {
            return $"{base.ToString()}, wings length: {_wingsLength}, stamina: {_stamina}";
        }
    }
}
