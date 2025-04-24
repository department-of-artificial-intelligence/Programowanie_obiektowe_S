using Generic.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.BLL
{
    public class Zoo : IDisplayable, IContainer
    {
        protected string _name;
        protected IList<Employee> _employees;
        protected IList<Cage> _cages;
        protected IList<Animal> _animals;

        public string Name
        {
            get => _name; set => _name = value;
        }
        public IList<Employee> Employees
        {
            get => _employees; set => _employees = value;
        }

        public IList<Cage> Cages
        {
            get => _cages; set => _cages = value;
        }
        public IList<Animal> Animals
        {
            get => _animals; set => _animals = value;
        }

        public Zoo(string name, IList<Employee> employees, IList<Cage> cages, IList<Animal> animals)
        {
            Name = name;
            Employees = employees ?? new List<Employee>();
            Cages = cages ?? new List<Cage>();
            Animals = animals ?? new List<Animal>();
        }

        public Cage BuildCage(int capacity, bool needsCleaning)
        {
            var newCage = new Cage(capacity, needsCleaning, new List<Animal>());
            Cages.Add(newCage);
            Console.WriteLine($"Cage added");
            return newCage;
        }

        public void ExpandCage(Cage cage, int extraSpace)
        {
            cage.Capacity += extraSpace;
            Console.WriteLine($"Cage expanded");
        }

        public Employee HireEmployee(string firstName, string lastName, DateTime birthDate)
        {
            var newEmployee = new CageSupervisor(firstName, lastName, birthDate, DateTime.Now, new List<Cage>());
            Employees.Add(newEmployee);
            Console.WriteLine($"New employee {firstName} hired");
            return newEmployee;
        }
        public override string ToString()
        {
            string sCages = Cages.Count.ToString();
            foreach(var c in Cages)
            {
                sCages += $"\n {c.ToString()}";
            }
            string sEmployees = Employees.Count.ToString();
            foreach(var e in Employees)
            {
                sEmployees += $"\n {e.ToString()}";
            }
            string sAnimals = Animals.Count.ToString();
            foreach(var a in Animals)
            {
                sAnimals += $"\n {a.ToString()}";
            }

            return $"{Name}, Cages: {sCages}, Employees: {sEmployees}, Animals: {sAnimals}";
        }
    }
}