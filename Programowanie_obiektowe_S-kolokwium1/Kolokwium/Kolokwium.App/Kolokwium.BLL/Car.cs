using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.BLL
{
    public abstract class Car:IDisplay
    {
        public string RegistrationNumber { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public Car(string brand, string model, string registrationNumber) {
            RegistrationNumber = registrationNumber;
            Model = model;
            Brand = brand;
        }

        public override string ToString()
        {
            return $"Registration number:{RegistrationNumber}, Model:{Model}, Brand:{Brand}";
        }

        public virtual void Display()
        {
            Console.WriteLine(this.ToString() );
        }
    }
}
