using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab5.BLL
{
    public class Bird : Animal
    {

        public string Food { get; set; }
        public int Cage { get; set; }
        public string Nation { get; set; }
        public string Type { get; set; }
        public int Wytrzymalosc { get; set; }
        public int Rozpietosc { get; set; }

        public Bird(string food, int cage, string nation, string type, int wytrzymalosc, int rozpietosc)
        {

            Food = food;
            Cage = cage;
            Nation = nation;
            Type = type;
            Wytrzymalosc = wytrzymalosc;
            Rozpietosc = rozpietosc;

        }

        public override string ToString()
        {
            return $"Bird| Food {Food}, Cage {Cage},  Nation {Nation}, Wytrzymalosc {Wytrzymalosc}, Rozpietosc {Rozpietosc}";
        }
    }
}