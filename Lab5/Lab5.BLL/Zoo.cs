using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Zoo
    {
        protected string _zooName;
        protected System.Collections.Generic.List<Employee> _employees;
        protected System.Collections.Generic.List<Cage> _cages;
        protected System.Collections.Generic.List<Animal> _animals;

        public Zoo(string v, List<Employee> employees, List<Cage> cages, List<Animal> animals)
        {
            _zooName = v;
            _employees = employees;
            _cages = cages;
            _animals = animals;
        }
    }
}