using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.BLL
{
    public class Client : Person
    {
        public DateTime ValidityDate { get; set; }
        public Car Car {  get; set; }
        public decimal Price { get; set; }

        public Client(string firstName, string lastName, DateTime dateOfBirth, DateTime validityDate, Car car, decimal price)
            :base(firstName, lastName, dateOfBirth)
        {
            ValidityDate = validityDate;
            Car = car;
            Price = price;
        }

        public override string ToString()
        {
            var str = base.ToString();
            str += $"Validity date: {ValidityDate} ";
            str += Car.ToString();
            str += $"price: {Price} ";
            return str;
        }
    }
}
