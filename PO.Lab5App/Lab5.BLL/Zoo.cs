using Generic.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Zoo:IContainer
    {
        protected string _name;
        public IList<Employee> Employees { get; set; }
        public IList<Cage> Cages { get; set; }

        public IList<Animal> Animals { get; set; }

        public string Name { get=>_name; set=>_name=value; }

        public Zoo(string name, IList<Employee> employees, IList<Cage> cages, IList<Animal> animals)
        {
            Name= name;
            Employees = employees;
            Cages = cages;
            Animals = animals;
        }

        public Cage BuildCage(int capacity, bool isDirty)
        {
            return new Cage(capacity, isDirty,new List<Animal>());
        }

        public void ExpandCage(Cage cage, int v)
        {
            cage.Capacity += v;
        }

        public CageSupervisor HireEmployee(string name, string surname, DateTime birthDate)
        {
            CageSupervisor newEmp = new CageSupervisor(name, surname, birthDate
                ,DateTime.Now,new List<Cage>());
            Employees.Add(newEmp);
            return newEmp;
        }
        public override string ToString()
        {
            string res = $"Name : {Name}\n\tEmployees : \n";
            foreach(var emp in Employees)
            {
                res += "\t\t"+emp.ToString()+"\n";
            }
            res += "\tCages : \n";
            foreach (var emp in Cages)
            {
                res += "\t\t" + emp.ToString() + "\n";
            }
            res += "\tAnimals : \n";
            foreach (var emp in Animals)
            {
                res += "\t\t" + emp.ToString() + "\n";
            }
            return res ;
        }
    }
}