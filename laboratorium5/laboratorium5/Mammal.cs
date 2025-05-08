using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorium5
{
    public class Mammal: Animal
    {
        private string _naturalHabitat;

        public Mammal(string foodType, int legsCount, string origin, string spieces, string habitat ) : base(foodType, legsCount, origin, spieces)
        {
            _naturalHabitat = habitat;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, habitat: {_naturalHabitat}";
        }
    }
}
