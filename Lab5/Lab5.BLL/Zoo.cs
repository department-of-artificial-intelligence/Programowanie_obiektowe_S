using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.BLL
{
    public class Zoo
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

        public IList <Animal> Animals
        {
            get => _animals; set => _animals = value;
        }

        public Zoo(string name, IList<Employee> employees, IList<Cage> cages, IList<Animal> animals)
        {
            Name = name ?? string.Empty;
            Employees = employees ?? new List<Employee>();
            Cages = cages ?? new List<Cage>();
            Animals = animals ?? new List<Animal>();
        }

        public Cage BuildCage(int capacity, bool needsCleaning)
        {
            var newCage = new Cage(capacity, needsCleaning, new List<Animal>());
            Cages.Add(newCage);
            return newCage;
        }

        public void ExpandCage(Cage cage, int additionalSpace)
        {
            cage.Capacity += additionalSpace;
        }

        public override string ToString()
        {
            return $"Zoo: {Name}, Cages: {Cages.Count}, Employees: {Employees.Count}, Animals: {Animals.Count}";
        }
    }
}