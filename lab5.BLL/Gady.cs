using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab5.BLL
{
    public class Reptile : Animal
    {
        public string Food { get; set; }
        public int Cage { get; set; }
        public string Nation { get; set; }
        public string Type { get; set; }
        public bool Jad { get; set; }

        public Reptile(string food, int cage, string nation, string type, bool jad)
        {


            Food = food;
            Cage = cage;
            Nation = nation;
            Type = type;
            Jad = jad;

        }

        public override string ToString()
        {
            return $"Reptille| Food {Food}, Cage {Cage}, Nation {Nation}, Type {Type}, Jad {Jad}";
        }

    }
}