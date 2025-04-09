using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Mammal : Animal
    {
        private string _naturalHabitat;


        public Mammal(string foodType, int number, string origin, string specie, string naturalHabitat) : base(foodType, number, origin, specie)
        {
            _naturalHabitat=naturalHabitat;
        }
    }
}