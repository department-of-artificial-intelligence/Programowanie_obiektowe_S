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
        private string _traits;
        private string _abilities;
        private int _stamina;

        public IList<Cage> Cage { get; set; } = new List<Cage>();


        public int Stamina { get { return _stamina; } set { _stamina = value; } }
        public string FoodType { get { return _foodType; } set { _foodType = value; } }
        public int LegsCount { get { return _legsCount; } set { _legsCount = value; } }
        public string Origin { get { return _origin; } set { _origin = value; } }
        public string Species { get {return _species;} set { _species = value; } }
        public string Traits { get { return _traits;} set { _traits = value; } }
        public string Abilities { get {return _abilities;} set { _abilities = value; } }





        public Animal()
        {
            throw new System.NotImplementedException();
        }
    }
}