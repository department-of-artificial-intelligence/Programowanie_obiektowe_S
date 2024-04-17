using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.BLL
{
    public class Truck : TCar
    {
        

        public float MaxCapacity {  get; set; }
        public Truck(string brand, string model, string registractiomNumber , float maxCapacity) : base(brand, model, registractiomNumber)
        {
            MaxCapacity = maxCapacity;
        }
        public override string ToString()
        {
            return base.ToString() + $"Max pojemnosc:{MaxCapacity}";
        }
    }
}
