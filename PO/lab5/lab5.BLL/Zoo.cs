using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab5.BLL
{
    public class Zoo
    {
        private string _name;
        private System.Collections.Generic.List<Animal> _Animals;
        private System.Collections.Generic.List<Employee> _Employees;
        private System.Collections.Generic.List<Cage> _Cages;
        
        public string name { get { return _name; } }
        public Zoo(string name, List<Animal> animals, List<Employee> employees, List<Cage> cages )
        {
            _name = name;
            _Animals = animals;
            _Employees = employees;
            _Cages = cages;
        }
         
    }
}