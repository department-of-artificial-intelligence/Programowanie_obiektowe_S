using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.BLL
{
    public class Truck : Car
    {
        public float MaxCapacity { get; set; }
        public Truck(string brand, string model, string registrationNumber, float maxCapacity)
            :base(brand, model, registrationNumber)
        {
            MaxCapacity = maxCapacity;
        }
        public override string ToString()
        {
            var str = base.ToString();
            str += $"Max capacity: {MaxCapacity} ";
            return str;
        }
    }
}
