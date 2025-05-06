using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            this.Cars = new List<TCar>();
            this.Clients = new List<Client>();
            this.Employees = new List<Employee>();

        }
        public void AddCar(Client client, TCar car)
        {
            //if (this.Cars.Contains(car)) { this.Cars.Add(car);}
            if (Clients is not null)
            {
                this.Cars.Add(car);
            }
                       
        }
        /*
        public TCar RemoveCar(string registrationNumber)
        {
            if(this.Cars.Contains(Car.registrationNumber)!= null) 
            {
                this.Cars.Remove(Car.registrationNumber);
            }
        }
        */
        public override string ToString()
        {
            string napis = "";
            napis += $"Localization: {Localization} ";
            napis += $"Cars: \n";
            this.Cars.ToList().ForEach(cars => napis += cars + "\n");
            napis += $"Clients: \n";
            this.Clients.ToList().ForEach(clients => napis += clients + "\n");
            napis += $"Employees: \n";
            this.Employees.ToList().ForEach(employees => napis += employees + "\n");
            return base.ToString() + napis;
        }
        public void Display() { Console.WriteLine(this); }
    }
}
