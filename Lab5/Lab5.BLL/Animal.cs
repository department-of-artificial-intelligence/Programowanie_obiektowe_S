using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Animal
    {
        private string _foodType;
        private int _legsCount;
        private string _origin;
        private string _species;


        public IList<Cage> Cage { get; set; } = new List<Cage>();


        
        public string FoodType { get { return _foodType; } set { _foodType = value; } }
        public int LegsCount { get { return _legsCount; } set { _legsCount = value; } }
        public string Origin { get { return _origin; } set { _origin = value; } }
        public string Species { get { return _species; } set { _species = value; } }


        //public string Traits { get { return _traits; } set { _traits = value; } }
        //public string Abilities { get { return _abilities; } set { _abilities = value; } }
        //public int Stamina { get { return _stamina; } set { _stamina = value; } }




        public Animal(string foodType, int legs, string origin, string species) 
        {
            _foodType = foodType;
            _legsCount = legs;
            _origin = origin;
            _species = species;
        }


        public override string ToString() 
        {
            return $" Species: {_species}, Food: {_foodType}, Legs: {_legsCount}, Origin: {_origin}";
        }
    }
}