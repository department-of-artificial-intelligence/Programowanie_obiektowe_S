using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.BLL
{
    public class RegularCar : TCar
    {
        public int DoorCount { get; set; }
        public RegularCar(string brand, string model, string registractiomNumber , int doorCount) : base(brand, model, registractiomNumber)
        {
            DoorCount = doorCount;
        }
        public override string ToString()
        {
            return base.ToString() + $"Ilosc drzwi:{DoorCount}";
        }
    }
}
