using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Zoo
    {
        public string Name { get; set; }
        public IList<Animal> Animals { get; set; }
        public IList<Employee> Employees { get; set; }
        public IList<Cage> Cages { get; set; }

        public Zoo(string name, IList<Animal> animals, IList<Employee> employees
            , IList<Cage> cages)
        {
            Name = name;
            Animals = animals;
            Employees = employees;
            Cages = cages;
        }
    }
}