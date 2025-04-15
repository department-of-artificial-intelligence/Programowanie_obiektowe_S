using System;
using System.Collections.Generic;
//using System.ComponentModel;
using System.Linq;
using System.Text;
using Generic.Extensions;

namespace Lab5.BLL
{
    public class Zoo: IContainer, IDisplayable
    {
        private string _name;
        private System.Collections.Generic.IList<Employee> _employees;
        private System.Collections.Generic.IList<Cage> _cages;
        private System.Collections.Generic.IList<Animal> _animals;

        public Zoo(string name, System.Collections.Generic.IList<Employee> employees, System.Collections.Generic.IList<Cage> cages, System.Collections.Generic.IList<Animal> animals)
        {
            _name = name;
            _employees = employees;
            _cages = cages;
            _animals = animals;
        }

        public Cage Cage
        {
            get => default;
            set
            {
            }
        }

        public Animal Animal
        {
            get => default;
            set
            {
            }
        }

        public Employee Employee
        {
            get => default;
            set
            {
            }
        }

        public Cage BuildCage(int size, bool needsCleaning)
        {
            _cages.Add(new Cage(size, needsCleaning, new List<Animal>()));
            return _cages.Last();
        }

        public void ExpandCage(Cage cage, int newSize)
        {
            cage.Expand(newSize);
        }

        public override string ToString()
        {
            return "wypisuje zoo, todoooo";
        }

        public Employee HireEmployee(string firstName, string lastName, System.DateTime dateOfBirth)
        {
            _employees.Add(new Employee(firstName, lastName, dateOfBirth));
            return _employees.Last();
        }
    }
}
