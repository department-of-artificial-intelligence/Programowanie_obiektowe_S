using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorium5
{
    public class Reptile: Animal
    {
        private bool _venomous;

        public Reptile(string foodType, int legsCount, string origin, string spieces, bool venomous ) : base(foodType, legsCount, origin, spieces)
        {
            _venomous = venomous;
        }

        public override string ToString()
        {
            return $"{ base.ToString()}, venomous: {_venomous}";
        }
    }
}
