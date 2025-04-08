using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Zoo
    {
        private string _name;
        private System.Collections.Generic.List<Employee> _employees;
        private System.Collections.Generic.List<Cage> _cages;
        private System.Collections.Generic.List<Animal> _animals;

        public Zoo(string name, System.Collections.Generic.List<Employee> employees, System.Collections.Generic.List<Cage> cages, System.Collections.Generic.List<Animal> animals)
        {
            _name = name;
            _employees = employees;
            _cages = cages;
            _animals = animals;
        }

        public Employee Employee
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

        public Cage Cage
        {
            get => default;
            set
            {
            }
        }
    }
}