using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.BLL
{
    public class Parking<TCar>
    {
        public string Localization { get; set; }
        public IList<TCar> Cars { get; set; }
        public IList<Client> Clients { get; set; }
        public IList<Employee> Employees { get; set; }

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

        //public TCar? RemoveCar(string registrationNumber)
        //{
        //    foreach (var item in Cars)
        //    {
        //        Car removeCar = item as Car;
        //        if (removeCar.RegistrationNumber == registrationNumber)
        //        {
        //            Cars.Remove(item);
        //        }
        //    }
        //    return default;
        //}

        public override string ToString()
        {
            string cars = string.Join("\n", Cars);
            string clients = string.Join("\n", Clients);
            string employees = string.Join("\n", Employees);
            return $"Parking | Localization: {Localization}, Cars:\n{cars}, Clients:\n{clients}, Employees:\n{employees}";
        }

        public void Display()
        {
            Console.WriteLine(this);
        }
    }
}
