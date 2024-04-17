using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.BLL
{
    public class Client: Person
    {
        public DateTime ValidityDate { get; set; }
        public Car Car { get; set; }
        public decimal Price { get; set; }
        public Client(string firstName, string lastName, DateTime dateOfBirth, DateTime validityDate, Car car, decimal price): base(firstName,lastName, dateOfBirth)
        {
            ValidityDate = validityDate;
            Car = car;
            Price = price;
        }
        public override string ToString()
        {
            return $"Client | FirstName: {FirstName}, LastName: {LastName}, DateOfBirth: {DateOfBirth}, ValidityDate: {ValidityDate},\ntCar: {Car}, Price: {Price}";
        }
    }
}
