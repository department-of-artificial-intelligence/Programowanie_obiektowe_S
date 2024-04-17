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
        public IList <Client> Clients { get; set; }
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

        /*public TCar RemoveCar(string registrationNumber)
        {

            

        }*/

        public override string ToString()
        {
            string nazwaCar = string.Join(",\n ", Cars.Select(a => a.ToString()));
            string nazwaClient = string.Join(",\n ", Clients.Select(a => a.ToString()));
            string nazwaEmployee = string.Join(",\n ", Employees.Select(a => a.ToString()));
            return $"Localization: {Localization}\nCars: {nazwaCar}\nClients: {nazwaClient}\nEmployess: {nazwaEmployee}\n";
        }

        public void Display()
        {
            Console.WriteLine(this.ToString() );
        }

    }
}
