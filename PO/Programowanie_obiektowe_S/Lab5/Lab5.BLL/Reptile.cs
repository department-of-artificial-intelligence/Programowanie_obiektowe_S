using Generic.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Reptile : Animal, IDisplayable
    {
        private bool _isPoison;

        public bool Poison { get { return _isPoison; } set { _isPoison = value; } }

        public Reptile(string foodType, int legsCount, string orign, string species, bool isPoison) : base(foodType, legsCount, orign, species)
        {
            _isPoison = isPoison;
        }

        public override string ToString()
        {
            return $"Reptile:{base.ToString()}, Poison: {Poison}";
        }




    }
}