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
        public void AddCar(Client client , TCar car)
        {
            Clients.Add(client);
            Cars.Add(car);
        }
        /////////////////// Funkcja nie działa z powodu mojego barku umiejestosci odniesienia sie do zmieniej "RegistractiomNumber"
        /*
        public TCar RemoveCar(string resignationNumber)
        {
            foreach(var car in Cars)
            {
                if (Cars.RegistractiomNumber != resignationNumber)
                {
                    Cars.Remove(car);
                }        
            }
            return default;
        }
        */
        public override string ToString()
        {
            string auta = string.Empty;
            string klienci = string.Empty;  
            string pracownicy = string.Empty;
            auta += string.Join("\n", Cars);
            klienci += string.Join("\n", Clients);
            pracownicy += string.Join("\n", Employees);
            return $"Lokalizacja:{Localization} Auta:\n{auta} Klienci:\n{klienci} Pracownicy:\n{pracownicy}";
        }
        public void Display()
        {
            Console.WriteLine(this);
        }
    }
}
