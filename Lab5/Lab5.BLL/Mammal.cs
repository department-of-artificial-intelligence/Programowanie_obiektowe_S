using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Mammal : Animal
    {
        private string _nutrition;
        private int _legsCount;
        private string _placeOfOccurance;
        private string _species;
        private string _naturalEnvironment;

        public string Nutrition { get => _nutrition; set => _nutrition = value; }
        public int LegsCount { get => _legsCount; set => _legsCount = value; }
        public string PlaceOfOccurance { get => _placeOfOccurance; set => _placeOfOccurance = value; }
        public string Species { get => _species; set => _species = value; }
        public string NaturalEnvironment { get => _naturalEnvironment; set => _naturalEnvironment = value; }
    }
}