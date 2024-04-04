using Generic.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Reptile : Animal, IContainer
    {
        private int _legsCount;
        private bool _venomous;

        public int LegsCount { get => _legsCount; set => _legsCount = value; }
        public bool Venomous { get => _venomous; set => _venomous = value; }

        public Reptile(string nutrition, int legsCount, string origin, string species, bool venomous)
            :base(nutrition, species, origin)
        {
            LegsCount = legsCount;
            Venomous = venomous;
        }

        public override string ToString()
        {
            var str = base.ToString();
            str += $"legs count: {LegsCount}, is venomous: {Venomous}";
            return str;
        }
    }
}