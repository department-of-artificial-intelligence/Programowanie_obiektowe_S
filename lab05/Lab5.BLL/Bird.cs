using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Bird:Animal
    {
        public double _wingsWidth;
        public int _durability;

        public double wingsWidth {  get; set; }

        public int durability { get; set; }


        public Bird() : base() { }

        public Bird(string foodType, int legCount, string origin, string spieces, double wingsWidth, int durability):base(foodType,legCount,origin,spieces)
        {
            _wingsWidth = wingsWidth;
            _durability = durability;
        }

        public void Fly()
        {
            double ilocz=_wingsWidth * _durability;
            Console.WriteLine($"Ptak przelecial {ilocz}");
        }



    }
}