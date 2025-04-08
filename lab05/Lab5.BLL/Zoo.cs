using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Zoo
    {
        private string _Nazwa {  get; set; }

        public System.Collections.Generic.IList<Employee> Employees { get; set; }   
        public System.Collections.Generic.IList<Animal> Animals { get; set; }  
        public System.Collections.Generic.IList<Cage> Cages { get; set; }       
        
        public Zoo(string nazwa, IList<Employee> employees, IList<Cage> cages, IList<Animal> animals)
        {
            _Nazwa = nazwa;
            Employees = employees;
            Animals = animals;
            Cages = cages;
        }
    }
}