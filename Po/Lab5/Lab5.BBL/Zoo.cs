using Generic.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Lab5.BBL
{
    public class Zoo : Generic.Extensions.IContainer, IDisplayable
    {
        private string _name;
        private System.Collections.Generic.IList<Employee> _employee;

        public string Name
        {
            get;set;
        }

        public System.Collections.Generic.IList<Employee> Employe
        {
            get;set;
        }

        public System.Collections.Generic.IList<Cage> _Cage
        {
            get;
            set;
            
        }

        public System.Collections.Generic.IList<Animal> _Animal
        {
            get;
            set;
        }

        public Zoo(string name, IList<Employee> employe, IList<Cage> cage, IList<Animal> animal)
        {
            Name = name;
            
            Employe = employe;
            _Cage = cage;
            _Animal = animal;
        }

        public Cage BuildCage(int id, bool IsAnimal)
        {
            Cage cage1 = new Cage(id,IsAnimal,new List<Animal>());
            _Cage.Add(cage1);
            return cage1;
        }

        public void ExpandCage(Cage cage, int number)
        {
            cage.NumberOfCage += number;
            Console.WriteLine(cage.NumberOfCage);
        }
        public Employee HireEmployee(string firstName, string lastName, DateTime date)
        { 
            return new CageSupervisor(firstName, lastName, date,new List<Cage>());
        }
        public override string ToString()
        {
            string employee = string.Join(", ", Employe.Select(a => a.ToString()));
            string cage = string.Join(", ", _Cage.Select(a => a.ToString()));
            string animal = string.Join(", ", _Animal.Select(a => a.ToString()));
            return $"Name: {Name}, Employee: {employee}, Cage: {cage}, Animal: {animal}";
        }
    }
}