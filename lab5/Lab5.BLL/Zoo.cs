using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Generic.Extensions;

namespace Lab5.BLL
{
    public class Zoo : IDisplayable, IContainer
    {
        private string _name;
        public string Name { get { return _name; } set { _name = value; } }
        public IList<Employee> Employees { get; set; }
        public IList<Cage> Cages { get; set; }
        public IList<Animal> Animals { get; set; }
        public Zoo(string name, IList<Employee> employees, IList<Cage> cages, IList<Animal> animals)
        {
            Name = name;
            Employees = employees;
            Cages = cages;
            Animals = animals;
        }
        public Cage BuildCage(int capacity, bool iscleaned)
        {
            Cage cage = new Cage(capacity, iscleaned);
            Cages.Add(cage);
            return Cages[Cages.Count-1];
        }
        public Employee HireEmployee(string name, string lastName, DateTime dateOfBirth)
        {
            Employee employee = new CageSupervisor(name, lastName, dateOfBirth, DateTime.Now, new List<Cage>());
            Employees.Add(employee);
            return employee;
        }
        public void ExpandCage(Cage cage, int capacity)
        {
            var findCage=Cages.FirstOrDefault(c=>c.Number==cage.Number);
            findCage.Capacity+= capacity;
        }
        public override string ToString()
        {
            Console.WriteLine(Name);
            foreach (var cage in Cages)
            {
                Console.WriteLine(cage);
            }
            return "";
        }
    }
}