using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Bird : Animal
    {
        private string _nutrition;
        private int _legsCount;
        private string _placeOfOccurance;
        private string _sprecies;
        private string _wingspan;
        private int _stamina;

        public string Nutrition { get => _nutrition; set => _nutrition = value; }
        public int LegsCount { get => _legsCount; set => _legsCount = value; }
        public string PlaceOfOccurance { get => _placeOfOccurance; set => _placeOfOccurance = value; }
        public string Sprecies { get => _sprecies; set => _sprecies = value; }
        public string Wingspan { get => _wingspan; set => _wingspan = value; }
        public int Stamina { get => _stamina; set => _stamina = value; }

        public void Fly()
        {
            throw new System.NotImplementedException();
        }
    }
}