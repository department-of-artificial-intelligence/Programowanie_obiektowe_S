using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Zoo
    {
        private string _name;
        private IList<Employee> employees;
        private IList<Cage> cages;
        private IList<Animal> animals;

        public string Name { get => _name; set => _name = value; }
        public IList<Employee> Employees { get => employees; set => employees = value; }
        public IList<Cage> Cages { get => cages; set => cages = value; }
        public IList<Animal> Animals { get => animals; set => animals = value; }

        public Zoo(string name, IList<Employee> employees, IList<Cage> cages, IList<Animal> animals)
        {
            Name = name;
            Employees = employees;
            Cages = cages;
            Animals = animals;
        }

        public override string ToString()
        {
            var str = $"Name: {Name}";
            str += string.Join<Employee>('\n', Employees);
            str += string.Join<Cage>('\n', Cages);
            str += string.Join<Animal>('\n', Animals);
            return str;

        }
    }
}