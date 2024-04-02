using Generic.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Mammal : Animal, IDisplayable
    {
        private string _naturalOrigin;

        public string NaturalOrigin { get => _naturalOrigin; set => _naturalOrigin = value; }

        public Mammal(string foodType, int legsCount, string orign, string specie, string naturalOrigin) :base(foodType,legsCount,orign,specie)
        {
            NaturalOrigin = naturalOrigin;
        }

        public override string ToString()
        {
            return $"Mamals :{base.ToString()}, NaturalOrigin: {NaturalOrigin}";
        }
    }
}