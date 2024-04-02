using Generic.Extensions;
using Lab5.BLL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Lab5.BLL
{
    public class Zoo : IDisplayable, IContainer
    {
        private string _name;
        private IList<Cage> _cages;
        private IList<Employee> _employees;
        private IList<Animal> _animals;

        public string Name { get => _name; set => _name = value; }
        public IList<Cage> Cages { get => _cages; set => _cages = value; }
        public IList<Employee> Employees { get => _employees; set => _employees = value; }
        public IList<Animal> Animals { get => _animals; set => _animals = value; }
        public Zoo(string nam, IList<Employee> employees, IList<Cage> cages, IList<Animal> animals)
        {
            Name = nam;
            Cages = cages;
            Employees = employees;
            Animals = animals;
        }
        public Cage BuildCage(int cap, bool cleaned)
        {
            Cage cage = new Cage(cap, cleaned);
            Cages.Add(cage);
            return Cages[Cages.Count - 1];
        }
        public void ExpandCage(Cage cage, int capac)
        {
            var fnd = Cages.FirstOrDefault(c => c.Id == cage.Id);
            fnd.Capacity += capac;
        }
        public Employee HireEmployee(string FName, string LName, DateTime DOB)
        {
            var employee = new CageSupervisor(FName, LName, DOB, new List<Cage>());
            Employees.Add(employee);
            return employee;

        }
        public override string ToString()
        {
            Console.WriteLine($"Ogrod zoologiczny: {Name}, which includes in itself: ");
            foreach (var cage in Cages)
            {
                Console.WriteLine(cage);
            }
            return "";
        }
    }
}

