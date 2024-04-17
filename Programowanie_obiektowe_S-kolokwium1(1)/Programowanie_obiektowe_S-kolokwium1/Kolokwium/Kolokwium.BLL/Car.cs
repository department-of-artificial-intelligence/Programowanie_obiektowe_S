using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.BLL
{
    public abstract class Car : IDisplay
    {
        public string RegistrationNumber { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }

        public Car(string brand, string model, string registrationNumber)
        {
            Brand = brand;
            Model = model;
            RegistrationNumber = registrationNumber;
        }

        public override string ToString()
        {
            return $"Car | Brand: {Brand}, Model: {Model}, Registration number: {RegistrationNumber}";
        }

        public void Display()
        {
            Console.WriteLine(this);
        }
    }
}
