using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Generic.Extensions;

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

        public Employee HireEmployee(string firstName, string lastName, DateTime dateOfBirth)
        {
            var newEmployee = new Employee(firstName, lastName, dateOfBirth);
            Employees.Add(newEmployee);
            return newEmployee;
        }

        public override string ToString()
        {
            var cageIds = Cages.Any() ? string.Join(", ", Cages.Select(c => c.Id)) : "none";
            var employeeNames = Employees.Any() ? string.Join(", ", Employees.Select(e => $"{e.FirstName} {e.LastName}")) : "none";
            var animalSpecies = Animals.Any() ? string.Join(", ", Animals.Select(a => a.Species)) : "none";

            return $"Zoo: {Name}, Cages: {Cages.Count} [{cageIds}], Employees: {Employees.Count} [{employeeNames}], Animals: {Animals.Count} [{animalSpecies}]";
        }

    }
}