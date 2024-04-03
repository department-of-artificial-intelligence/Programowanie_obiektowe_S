using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Reptile : Animal
    {
        private string _nutrition;
        private int _legsCount;
        private string _placeOfOccurance;
        private string _species;
        private bool _venomous;

        public string Nutrition { get => _nutrition; set => _nutrition = value; }
        public int LegsCount { get => _legsCount; set => _legsCount = value; }
        public string PlaceOfOccurance { get => _placeOfOccurance; set => _placeOfOccurance = value; }
        public string Species { get => _species; set => _species = value; }
        public bool Venomous { get => _venomous; set => _venomous = value; }
    }
}