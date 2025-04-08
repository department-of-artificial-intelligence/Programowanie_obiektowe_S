using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Animal
{
    public string Diet { get; set; }

    public int Legs { get; set; }
    public string Habitat { get; set; }
    public string Species { get; set; }
    public string Origin { get; set; }
    public Animal(string diet, int legs, string habitat, string species, string origin)
    {
        Diet = diet;
        Legs = legs;
        Habitat = habitat;
        Species = species;
        Origin = origin;

    }
    public override string ToString()
    {
        return $"{Species} (Diet: {Diet}, Legs: {Legs}, Habitat: {Habitat}, Origin: {Origin})";
    }
}
