using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.BLL
{
    public class Parking<TCar>
    {
        public string Localization { get; set; }
        IList<TCar> Cars { get; set; }
        IList<Client> Clients { get; set; }
        IList<Employee> Employees { get; set; }
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
        public TCar? RemoveCar(string registrationNumber)
        {
            foreach (var item in Cars)
            {
                Car Todelete = item as Car;
                if (Todelete.RegistrationNumber == registrationNumber)
                    Cars.Remove(item);
                return default;
                
            }
            
            return default;
        }


        public override string ToString()
        {
            string stringClients= string.Join("\n", Clients);
            string stringEmployees = string.Join("\n", Employees);
            string stringCars = string.Join("\n", Cars);

            return $"PARKING | {Localization} \n {stringCars} \n{stringClients} \n{stringEmployees}";
        }

        public void Display() 
        {
            Console.WriteLine(this);
        }
    }
    }



