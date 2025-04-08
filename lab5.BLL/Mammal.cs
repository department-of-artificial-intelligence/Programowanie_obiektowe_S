using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab5.BLL
{
    public class Mammal : Animal
    {
        public string Food { get; set; }
        public int Cage { get; set; }
        public string Nation { get; set; }

        public string Type { get; set; }

        public string Enviroment { get; set; }

        public Mammal(string food, int cage, string nation, string type, string enviroment)
        {

            Food = food;
            Cage = cage;
            Nation = nation;
            Type = type;
            Enviroment = enviroment;

        }

        public override string ToString()
        {
            return $"Mammal| Food {Food}, Cage {Cage}, Nation {Nation} ";
        }

    }
}