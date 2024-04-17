using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.BLL
{
    public abstract class TCar : IDisplay
    {
        public string RegistractiomNumber { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public TCar(string brand , string model , string registractiomNumber)
        {
            Brand = brand;
            Model = model;
            RegistractiomNumber = registractiomNumber;
        }
        public override string ToString()
        {
            return $"Marka:{Brand} Model:{Model} Numer reg:{RegistractiomNumber} ";
        }
        public void Display()
        {
            Console.WriteLine(this);
        }
    }
}
