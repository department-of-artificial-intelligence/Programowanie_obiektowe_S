using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Mammal : Animal
    {
        private int _legsCount;
        private string _naturalEnvironment;

        public int LegsCount { get => _legsCount; set => _legsCount = value; }
        public string NaturalEnvironment { get => _naturalEnvironment; set => _naturalEnvironment = value; }

        public Mammal(string nutrition, int legsCount, string origin, string species, string naturalEnvironment)
            :base(nutrition, species, origin)
        {
            LegsCount = legsCount;
            NaturalEnvironment = naturalEnvironment;
        }

        public override string ToString()
        {
            var str = base.ToString();
            str += $"legs count: {LegsCount}, natural environment: {NaturalEnvironment}";
            return str;
        }
    }
}