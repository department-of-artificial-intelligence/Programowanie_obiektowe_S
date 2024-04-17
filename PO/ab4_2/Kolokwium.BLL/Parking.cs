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
            Cars.Add(car);
            Clients.Add(client);
        }
        public TCar RemoveCar(string registrationNumber)
        {
            foreach(TCar car in Cars)
            {
                if((car as Car).RegistrationNumber == registrationNumber )
                {
                    Cars.Remove(car);
                    return car;
                }
            }
            throw new Exception("Nie istnieje pojazd o podanym numerze rejestracyjnym");
        }
        public override string ToString()
        {
            string result = $"Parking | Localization: {Localization}\nCars:";
            foreach (TCar car in Cars)
            {
                result += $"\n\t{car}";
            }
            result += "\nClients:";
            foreach (Client client in Clients)
            {
                result += $"\n\t{client}";
            }
            result += "\nEmployees:";
            foreach (Employee employee in Employees)
            {
                result += $"\n\t{employee}";
            }
            return result;
        }
        public void Display()
        {
            Console.WriteLine(this);
        }
    }
}
