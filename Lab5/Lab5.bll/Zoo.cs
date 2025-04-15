using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lab5;
using Generic.Extensions;
namespace Lab5.bll
{
    public class Zoo:IContainer,IDisplayable
    {
        public string Name;
        public System.Collections.Generic.IList<Employee> Employess;
        public System.Collections.Generic.IList<Cage> Cages;
        private System.Collections.Generic.IList<Animal> Animals;
        public Zoo(string name, IList<Employee> employess, IList<Cage> cages, IList<Animal> animals)
        {
            Name = name;
            Employess = employess;
            Cages = cages;
            Animals = animals;
        }

        public Cage BuildCage(int capacity, bool isCageDirty, IList<Animal> animals)
        {
            Cage cage = new Cage(capacity, isCageDirty, animals);
            return cage;
        }
        public Cage BuildCage(int capacity, bool isCageDirty)
        {
            IList<Animal> animals=new List<Animal>();
            Cage cage = new Cage(capacity, isCageDirty, animals);
            return cage;
        }
        public Cage ExpandCage(Cage cage, int newcapacity)
        {
            cage.Capacity = newcapacity;
            return cage;
        }
        public Employee HireEmployee(string firstName, string lastName, DateTime dateOfBirth)
        {
            Employee employee = new Employee(firstName, lastName, dateOfBirth);
            return employee;

        }


    }
}