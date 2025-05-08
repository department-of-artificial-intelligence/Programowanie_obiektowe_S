using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorium5
{
    public abstract class Animal
    {
        private string _foodType;
        private int _legsCount;
        private string _origin;
        private string _spieces;

        public Animal(string foodType, int legsCount, string origin, string spieces)
        {
            _foodType = foodType;
            _legsCount = legsCount;
            _origin = origin;
            _spieces = spieces;
        }

        public override string ToString()
        {
            return $"food type: {_foodType}, legs: {_legsCount}, origin: {_origin}, spieces: {_spieces}";

        }
    }
}
