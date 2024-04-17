using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.BLL
{
    public class Parking<TCar>
    {
        public string Localization {  get; set; }
        public IList<TCar> Cars { get; set;}
        public IList<Client> Clients { get; set;}
        public IList<Employee> Employees { get; set;}
        public Parking(string localization, IList<TCar> cars, IList<Client> clients, IList<Employee> employees)
        {
            Localization = localization;
            Cars = cars;
            Clients = clients;
            Employees = employees;
        }
        public void AddCar(Client client, TCar car)
        {
            Clients.Add(client);
            Cars.Add(car);
        }

        //public TCar RemoveCar(string registrationNumber)
        //{
        //    //var type = Cars.GetType();
        //    var foundedCar = Cars.FirstOrDefault(p => p.RegistrationNumber == registrationNumber);
        //    Cars.Remove(foundedCar);
        //    return foundedCar;
        //}

        public override string ToString()
        {
            var str = $"Localization: {Localization} ";
            str += string.Join<TCar>('\n', Cars);
            str += string.Join("\n", Clients);
            str += string.Join("\n", Employees);
            return str;
        }
        public void Display()
        {
            Console.WriteLine(this);
        }
    }
}
