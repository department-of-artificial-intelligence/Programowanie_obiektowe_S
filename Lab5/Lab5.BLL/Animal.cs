using Generic.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Animal : IContainer
    {
        private string _nutrition;
        private string _species;
        private string _origin;

        public string Nutrition { get => _nutrition; set => _nutrition = value; }
        public string Species { get => _species; set => _species = value; }
        public string Origin { get => _origin; set => _origin = value; }

        public Animal(string nutrition, string species, string origin)
        {
            Nutrition = nutrition;
            Species = species;
            Origin = origin;
        }

        public override string ToString()
        {
            var str = $"Nutrition: {Nutrition}, Species: {Species}, Origin: {Origin}";
            return str;
        }
    }
}