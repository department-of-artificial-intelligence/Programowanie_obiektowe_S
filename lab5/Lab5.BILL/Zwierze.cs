using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gosha
{
    public class Animal
    {
        public string Diet { get; set; }
        public int Legs { get; set; }
        public string Habitat { get; set; }
        public string Species { get; set; }

        public Cage Cage
        {
            get => default;
            set
            {
            }
        }

        public Animal(string diet, int legs, string habitat, string species)
        {
            Diet = diet;
            Legs = legs;
            Habitat = habitat;
            Species = species;


        }
        public override string ToString()
        {
            return $"{Species} (Diet: {Diet}, Legs: {Legs}, Habitat: {Habitat})";
        }
    }
}
