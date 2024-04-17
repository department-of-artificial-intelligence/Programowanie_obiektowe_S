using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.BLL
{
    public class RegularCar : Car
    {
        public int DoorCount { get; set; }
        public RegularCar(string brand, string model, string registrationNumber, int doorCount)
            :base(brand, model, registrationNumber)
        {
            DoorCount = doorCount;
        }
        public override string ToString()
        {
            var str = base.ToString();
            str += $"Door count: {DoorCount} ";
            return str;
        }
    }
}
